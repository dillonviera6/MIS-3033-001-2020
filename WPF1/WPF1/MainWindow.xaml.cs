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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string name = string.Empty;
        string address = string.Empty;
        string zipCode = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            name = txtName.Text;
            address = txtAddress.Text;
            zipCode = txtZip.Text;

            EntryForm entryForm = new EntryForm(name, address, Convert.ToInt32(zipCode));

            lstBox.Items.Add($"Name: {name}     Address: {address}      Zipcode: {zipCode}");

            txtAddress.Text = string.Empty;
            txtName.Text = string.Empty;
            txtZip.Text = string.Empty;
        }

        public class ListBox : System.Windows.Controls.Primitives.Selector
        {

        }
    }
    
}
