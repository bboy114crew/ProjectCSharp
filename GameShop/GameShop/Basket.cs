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
            dataGridView1.DataSource = SessionOrder.getOrders.GetOrderList;
            float total = 0;
            foreach (var item in SessionOrder.getOrders.GetOrderList)
            {
                total += item.Quantity * item.UnitPrice;
            }
            lbTotal.Text = total.ToString();
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int id = CheckoutDB.insert(CustomerDB.getCustomerID(SessionOrder.user));
            foreach(OrderDetail o in SessionOrder.getOrders.GetOrderList)
            {
                CheckoutDB.insertOrderDetail(id, SessionOrder.productId, o.Quantity, o.UnitPrice * o.Quantity);
            }
            SessionOrder.getOrders = new Order();
            DialogResult result = MessageBox.Show("Checkout Success", "Confirmation", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Basket_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
