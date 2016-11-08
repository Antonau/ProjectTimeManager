using ServerSide;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using ClientSide.DialogWindows;
using ClientSide.DataContracts;

namespace ClientSide
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            refreshEmployeesComboBox();
            refreshProjectsComboBox();
        }
        
        private void Add_Employee_Button_Click(object sender, RoutedEventArgs e)
        {
            AddEmployeeWindow addEmployee = new AddEmployeeWindow();
            if (addEmployee.ShowDialog() == true)
            {
                if (ServerConnector.PlaceEmployee(addEmployee.FirstName, addEmployee.LastName))
                {
                    refreshEmployeesComboBox();
                }
                else
                {
                    string messageBoxText = "The entered employee first and last name have alredy exist! Please, enter another employee name.";
                    string caption = "Wrong employee name";
                    MessageBoxButton button = MessageBoxButton.OK;
                    MessageBoxImage icon = MessageBoxImage.Warning;
                    MessageBox.Show(this, messageBoxText, caption, button, icon);
                }
            }
        }

        private void Delete_Employee_Button_Click(object sender, RoutedEventArgs e)
        {
            string messageBoxText = "Do you want to remove the employee: " + ((ComboBoxItem)employeesComboBox.SelectedItem).Content + "?";
            string caption = "Remove employee";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Question;         
            MessageBoxResult result = MessageBox.Show(this, messageBoxText, caption, button, icon);
            if (result == MessageBoxResult.Yes)
            {
                int employeeId = (int)((ComboBoxItem)employeesComboBox.SelectedItem).Tag;
                ServerConnector.RemoveEmployee(employeeId);
                refreshEmployeesComboBox();
            }
        }
        private void Add_Project_Button_Click(object sender, RoutedEventArgs e)
        {
            AddProjectWindow addProject = new AddProjectWindow();
            if (addProject.ShowDialog() == true)
            {
                if (ServerConnector.PlaceProject(addProject.ProjectName))
                {
                    refreshProjectsComboBox();
                }
                else
                {
                    string messageBoxText = "The entered project name has alredy exist! Please, enter another project name.";
                    string caption = "Wrong project name";
                    MessageBoxButton button = MessageBoxButton.OK;
                    MessageBoxImage icon = MessageBoxImage.Warning;
                    MessageBox.Show(this, messageBoxText, caption, button, icon);
                }
            }
        }

        private void Delete_Project_Button_Click(object sender, RoutedEventArgs e)
        {
            string messageBoxText = "Do you want to remove the project: " + ((ComboBoxItem)projectsComboBox.SelectedItem).Content + "?";
            string caption = "Remove project";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Question;
            MessageBoxResult result = MessageBox.Show(this, messageBoxText, caption, button, icon);
            if (result == MessageBoxResult.Yes)
            {
                int projectId = (int)((ComboBoxItem)projectsComboBox.SelectedItem).Tag;
                ServerConnector.RemoveProject(projectId);
                refreshProjectsComboBox();
            }
        }
        private void Obtain_Time_Button_Click(object sender, RoutedEventArgs e)
        {
            int projectId = (int)((ComboBoxItem)projectsComboBox.SelectedItem).Tag;
            int employeeId = (int)((ComboBoxItem)employeesComboBox.SelectedItem).Tag;
            if (projectId > 0 && employeeId >0)
            {
                ObtainTimeWindow obtainTimeWindow = new ObtainTimeWindow();
                if (obtainTimeWindow.ShowDialog() == true)
                {
                    int hoursAmout = Int32.Parse(obtainTimeWindow.HoursAmount) + Int32.Parse(obtainTimeWindow.DaysAmount)*8;
                    if (ServerConnector.ObtainTime(hoursAmout, employeeId, projectId))
                    {
                        // May be toaster need ...
                    }
                }
            } else
            {
                string messageBoxText = "Please, select necessary employee and project and try again.";
                string caption = "Select error";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBox.Show(this, messageBoxText, caption, button, icon);
            }

        }
        private void Get_Report_Button_Click(object sender, RoutedEventArgs e)
        {
            string[] report = ServerConnector.GetReport();
            string reportPath = Environment.CurrentDirectory;
            using (StreamWriter reportFile = new StreamWriter(reportPath + @"\Report.txt"))
            {
                foreach (string line in report)
                {
                    reportFile.WriteLine(line);
                }             
            }
            Process.Start(reportPath + @"\Report.txt");
        }
        // Fill the ComboBoxes
        private void refreshEmployeesComboBox()
        {         
            EmployeeContract[] employees = ServerConnector.GetAllEmployees();
            employeesComboBox.Items.Clear();
            if (employees != null && employees.Count() > 0)
            {   
                foreach (EmployeeContract employee in employees)
                {
                    employeesComboBox.Items.Add(new ComboBoxItem { Content = employee.FirstName + " " + employee.LastName, Tag = employee.EmployeeId });
                }
            } else
            {
                employeesComboBox.Items.Add(new ComboBoxItem { Content = " - Add an employee -> ", Tag = 0 });
            }

            employeesComboBox.Items.Refresh();
            employeesComboBox.SelectedIndex = 0;
        }

        private void refreshProjectsComboBox()
        {
            ProjectContract[] projects = ServerConnector.GetAllProjects();
            projectsComboBox.Items.Clear();
            if (projects != null && projects.Count() > 0)
            {
                foreach (ProjectContract project in projects)
                {
                    projectsComboBox.Items.Add(new ComboBoxItem { Content = project.Name, Tag = project.ProjectId });
                }
            }
            else
            {
                projectsComboBox.Items.Add(new ComboBoxItem { Content = " - Add a project -> ", Tag = 0 });
            }
            projectsComboBox.Items.Refresh();
            projectsComboBox.SelectedIndex = 0;
        }
    }
}
