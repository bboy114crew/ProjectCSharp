using GameShop.DAL;
using GameShop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameShop
{
    public partial class Basket : Form
    {
        public Basket()
        {
            InitializeComponent();
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int id = CheckoutDB.insert(CustomerDB.getCustomerID(SessionOrder.user));
            foreach(OrderDetail o in SessionOrder.getOrders.GetOrderList)
            {
                CheckoutDB.insertOrderDetail(id, SessionOrder.productId, o.Quantity, o.UnitPrice * o.Quantity);
            }
            SessionOrder.getOrders = new Order();
        }
    }
}
