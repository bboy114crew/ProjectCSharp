using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop.Model
{
    class Images
    {
        public int id { get; set; }
        public Products product { get; set; }
        public string url { get; set; }

        public Images()
        {
            
        }

        public Images(int id, Products product, string url)
        {
            this.id = id;
            this.product = product;
            this.url = url;
        }
    }
}
