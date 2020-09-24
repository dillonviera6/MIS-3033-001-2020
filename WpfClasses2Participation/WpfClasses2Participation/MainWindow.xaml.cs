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

namespace WpfClasses2Participation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string manufacturer = string.Empty;
        string name = string.Empty;
        double price = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        public object AllMethods { get; private set; }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            manufacturer = txtManufacturer.Text;
            name = txtToyName.Text;
            price = Convert.ToDouble(txtToyPrice.Text);


            lstToyResults.Items.Add($"{manufacturer} {name}");

            txtManufacturer.Text = string.Empty;
            txtToyName.Text = string.Empty;
            txtToyPrice.Text = string.Empty;
        }

        private void lstToyResults_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
        Toy selectedToy = (Toy)lstToyResults.SelectedItem;
        MessageBox.Show(selectedToy.GetAisle());
        }
    }
}
