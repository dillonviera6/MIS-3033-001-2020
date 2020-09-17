using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1
{
    public class EntryForm
    {
        string Name { get; set; }

        string Address { get; set; }

        int ZipCode { get; set; }


        public EntryForm()
        {
            Name = string.Empty;
            Address = string.Empty;
            ZipCode = -1;
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
