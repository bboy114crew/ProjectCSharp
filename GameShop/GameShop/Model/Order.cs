using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop.Model
{
    class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        List<OrderDetail> list;
         public Order()
        {
            list = new List<OrderDetail>();
        }
        public Order(int OrderID,int CustomerID)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerID;
        }
        public List<OrderDetail> GetOrderList { get
            { return list; }
        }
    }
}
