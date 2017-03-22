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
    public partial class ProductDetail : Form
    {
        private int pid;

        public ProductDetail(int id)
        {
            InitializeComponent();
            pid = id;
        }

        private void ProductDetail_Load(object sender, EventArgs e)
        {
            ProductContext db = new ProductContext();
            db.getByID(pid);
        }

        private void btnAddcart_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnAddwishlist_Click(object sender, EventArgs e)
        {

        }
    }
}
