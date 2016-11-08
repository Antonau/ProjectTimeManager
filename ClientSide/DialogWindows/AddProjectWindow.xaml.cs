using System;
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
using System.Windows.Shapes;

namespace ClientSide.DialogWindows
{
    public partial class AddProjectWindow : Window
    {
        public AddProjectWindow()
        {
            InitializeComponent();
        }

        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void Window_ContentRendered(object sender, EventArgs e)
        {
            Project_Name.SelectAll();
            Project_Name.Focus();
        }
        private void SelectContent(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
        public string ProjectName
        {
            get { return Project_Name.Text; }
        }
    }
}
