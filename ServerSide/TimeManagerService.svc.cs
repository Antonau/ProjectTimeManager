using ServerSide.DataBase;
using ServerSide.DataContract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServerSide
{
    public class TimeManagerService : ITimeManagerService
    {
        // Operate on Employee
        public EmployeeContract[] GetAllEmployees()
        {
            EmployeeContract[] employees = null;  
            
            using (var db = new TimeManagerContext())
            {
                try
                {
                    var query = from e in db.Employees
                                orderby e.FirstName
                                select e;

                    employees = new EmployeeContract[query.Count()];
                    int counter = 0;
                    foreach (var item in query)
                    {
                        employees[counter] = new EmployeeContract { EmployeeId = item.EmployeeId, FirstName = item.FirstName, LastName = item.LastName };
                        counter++;
                    }
                }
                catch (Exception ex)
                {
                   // throw new FaultException<string>
                     Console.WriteLine(ex.Message);
                }
                
            }
            return employees;
        }

        public bool PlaceEmployee(EmployeeContract employee)
        {
            using (var db = new TimeManagerContext())
            {
                try
                {
                    var existEmployee = from e in db.Employees
                                        where e.FirstName == employee.FirstName
                                        && e.LastName == employee.LastName
                                        select e;
                    if (existEmployee.Count() == 0)
                    {
                        db.Employees.Add(new Employee { FirstName = employee.FirstName, LastName = employee.LastName });
                        db.SaveChanges();
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine (ex.Message);
                }
            }
            return true;
        }

        public bool RemoveEmployee(int employeeId)
        {
            using (var db = new TimeManagerContext())
            {
                try
                {
                    var removeEmployee = from e in db.Employees
                                         where e.EmployeeId == employeeId
                                         select e;
                    foreach (var employee in removeEmployee)
                    {
                        db.Employees.Remove(employee);
                    }
                    var removeEmployeeElapsedTime = from t in db.ElapsedTimes
                                                    where t.EmployeeId == employeeId
                                                    select t;
                    foreach (var employee in removeEmployeeElapsedTime)
                    {
                        db.ElapsedTimes.Remove(employee);
                    }
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return true;
        }
        // Operate on Projects
        public ProjectContract[] GetAllProjects()
        {
            ProjectContract[] projects = null;
            using (var db = new TimeManagerContext())
            {
                try
                {

                    var query = from p in db.Projects
                                orderby p.Name
                                select p;

                    projects = new ProjectContract[query.Count()];
                    int counter = 0;
                    foreach (var item in query)
                    {
                        projects[counter] = new ProjectContract { ProjectId = item.ProjectId, Name = item.Name };
                        counter++;
                    }
                }
                catch (Exception ex)
                {
                    // throw new FaultException<string>
                    Console.WriteLine(ex.Message);
                }
                
            }
            return projects;
        }

        public bool PlaceProject(ProjectContract project)
        {
            using (var db = new TimeManagerContext())
            {
                try
                {
                    var existRecords = from p in db.Projects
                                       where p.Name == project.Name
                                       select p;
                    if (existRecords.Count() == 0)
                    {
                        db.Projects.Add(new Project { Name = project.Name });
                        db.SaveChanges();
                    }
                    else
                    {
                        return false;
                    }
                    
                }
                catch (Exception ex)
                {
                    // throw new FaultException<string>
                    Console.WriteLine(ex.Message);
                }
            }
            return true;
        }

        public bool RemoveProject(int projectId)
        {
            using (var db = new TimeManagerContext())
            {
                try
                {
                    var removeProject = from e in db.Projects
                                         where e.ProjectId == projectId
                                         select e;
                    foreach (var project in removeProject)
                    {
                        db.Projects.Remove(project);
                    }
                    var removeProjectEladsedTime = from t in db.ElapsedTimes
                                                   where t.ProjectId == projectId
                                                   select t;
                    foreach (var project in removeProjectEladsedTime)
                    {
                        db.ElapsedTimes.Remove(project);
                    }
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return true;
        }
        // Obtain of time
        public bool ObtainTime(ObtainTimeContract obtainTime)
        {
            using (var db = new TimeManagerContext())
            {
                try
                {
                    var currentRecords = from oT in db.ElapsedTimes
                                         where oT.ProjectId == obtainTime.ProjectId
                                         && oT.EmployeeId == obtainTime.EmployeeId
                                         select oT;
                    if (currentRecords.Count() > 0)
                    {
                        foreach (var time in currentRecords)
                        {
                            time.Time += obtainTime.HoursAmount;
                        }
                    } else
                    {
                        db.ElapsedTimes.Add(new ElapsedTime { Time = obtainTime.HoursAmount, ProjectId = obtainTime.ProjectId, EmployeeId = obtainTime.EmployeeId });
                    }  
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    // throw new FaultException<string>
                    Console.WriteLine(ex.Message);
                }
            }
            return true;
        }
        // Get Report
        public string[] GetReport ()
        {
            ArrayList reportList = null;

            using (var db = new TimeManagerContext())
            {
                try
                {
                    reportList = new ArrayList();
                    reportList.Add("                 Report about time that was spent to the projects and amount of involved employees.");
                    reportList.Add("");
                    var projectsQuery = from p in db.Projects
                                        orderby p.Name
                                        select p;
                    int projectCount = 1;
                    foreach (var project in projectsQuery)
                    {
                        var timeQuery = from oT in db.ElapsedTimes
                                        where oT.ProjectId == project.ProjectId
                                        select oT;
                        if (timeQuery.Count() != 0)
                        {
                            int elapsedTime = 0;
                            foreach (var time in timeQuery)
                            {
                                elapsedTime += time.Time;
                            }
                            reportList.Add(String.Format("{0}. The project {1} have been involved {2} employees, and have took about {3} days and {4} hours,",
                                                         projectCount, project.Name, timeQuery.Count(), elapsedTime / 8, elapsedTime % 8));
                            reportList.Add("more details:");
                            foreach (var time in timeQuery)
                            {
                                var employeeQuery = from e in db.Employees
                                                    where e.EmployeeId == time.EmployeeId
                                                    select e;
                                reportList.Add(String.Format(" - {0} {1} has spent to the projec about {2} days and {3} hours, what is {4:P2} about of all project time;",
                                                            employeeQuery.First().FirstName, employeeQuery.First().LastName, time.Time / 8, time.Time % 8, time.Time * 1.0 / elapsedTime));
                            }
                            reportList.Add("");
                            projectCount++;
                        }
                        else
                        {
                            reportList.Add("Sorry, but project with involved employees and time spending isn't exist.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // throw new FaultException<string>
                    Console.WriteLine(ex.Message);
                }

            }
            return (string[]) reportList.ToArray(typeof(string));;
        }
    }  
}
