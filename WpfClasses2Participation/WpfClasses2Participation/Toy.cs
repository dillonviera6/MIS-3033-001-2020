using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClasses2Participation
{
    class Toy
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
        }

        public string GetAisle()
        {

        }
    }
}
