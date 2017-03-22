using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop.Model
{
    class SessionOrder
    {
        public static List<int> wishlist = new List<int>();
        public static Order getOrders = new Order();
        public static string user ="";
        public static int productId = -1;
    }
}
