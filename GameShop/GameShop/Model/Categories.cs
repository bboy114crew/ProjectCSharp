using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop.Model
{
    class Categories
    {
        public int id { get; set; }
        public int name { get; set; }

        public Categories()
        {
            
        }

        public Categories(int id, int name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
