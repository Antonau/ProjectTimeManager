using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class ObtainTimeWindow : Window
    {
        public ObtainTimeWindow()
        {
            InitializeComponent();
        }
        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void Window_ContentRendered(object sender, EventArgs e)
        {
            Days_Amount.SelectAll();
            Days_Amount.Focus();
        }

        private void SelectContent(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        public string DaysAmount
        {
            get { return Days_Amount.Text; }
        }
        public string HoursAmount
        {
            get { return Hours_Amount.Text; }
        }

 
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
