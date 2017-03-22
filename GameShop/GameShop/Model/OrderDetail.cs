using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop.Model
{
    class OrderDetail
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public OrderDetail()
        {

        }
        public OrderDetail(int orderid,int proid,int quantity,float price)
        {
            this.OrderID = orderid;
            this.ProductID = proid;
            this.Quantity = quantity;
            this.UnitPrice = price;
        }

     
    }
}
