using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop.Model
{
    class Suppliers
    {
        public int id { get; set; }
        public string name { get; set; }

        public Suppliers()
        {
            
        }

        public Suppliers(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
