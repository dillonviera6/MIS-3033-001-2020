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
    public class Toy
    {
        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        private string Aisle = string.Empty;

        public Toy()
        {
            string manufacturer = Manufacturer;
            string name = Name;
            double price = Price;
            string aisle = Aisle;
            GetAisle();
        }

        public string GetAisle()
        {
            double price = Price;
            string manufacturerLetter = Manufacturer.Substring(0, 1);
            string manufacturerCap = manufacturerLetter.ToUpper();
            string toyInfo = $"{manufacturerCap} {price}";
            return toyInfo;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
