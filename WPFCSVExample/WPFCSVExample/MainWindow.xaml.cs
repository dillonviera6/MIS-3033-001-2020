using System;
using System.Collections.Generic;
using System.IO;
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

namespace WPFCSVExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string filePath = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            filePath = txtFilePath.Text;

            if (File.Exists(filePath) == true)
            {
                btnProcess.IsEnabled = true;
                btnValidate.IsEnabled = false;
                txtFilePath.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Invalid file path. Please try again.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtFilePath.Clear();
                txtFilePath.Focus();

            }
        }

        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            string[] lines = File.ReadAllLines(filePath);
            double sum = 0;
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

                var pieces = line.Split(',');
                double price;

                if (double.TryParse(pieces[2], out price))
                {
                    sum += Convert.ToDouble(pieces[2]);
                }
                else
                {
                    MessageBox.Show($"Sorry, there was an invalid Price online {i+1}."); //tells them the line on which the error is on
                }

                lstFIle.Items.Add(pieces[1]); //Add the current line to the list box
            }
            MessageBox.Show($"The sum of all the product prices is {sum.ToString("C2")}.");
            ///foreach (var line in lines)
            ///{
            ///    var pieces = line.Split(',');
            ///    lstFIle.Items.Add(line); //Add the current line to the list box
            ///}
        }
    }
}
