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

        }
    }

    public class EntryForm
    {
        string Name { get; set; }

        string Address { get; set; }

        int ZipCode { get; set; }


        public EntryForm()
        {

        }

        public EntryForm(string name, string address, int zipCode)
        {
            name = Name;
            address = Address;
            zipCode = ZipCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
