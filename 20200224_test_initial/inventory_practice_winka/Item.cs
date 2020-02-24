using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_practice_winka
{
    public class Item
    {
        //fields
        //constructors
        public Item()
        {
        }

        //properties
        public string Name { get; set; }

        public string UPC { get; set; }
        public double Price { get; set; }
        public double CaseCost { get; set; }
        public double CaseUnits { get; set; }
        public string Distributor { get; set; }

        //methods
    }
}