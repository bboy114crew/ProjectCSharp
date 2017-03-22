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
        public ProductDetail()
        {
            InitializeComponent();
        }
        public List<int> listOrder { get; set; }
        public List<int> wishlist { get; set; }
        public int productID { get; set; }
        private void btnAddcart_Click(object sender, EventArgs e)
        {
            if (labelUsername.Text.Equals(""))
            {
                Login formLogin = new Login();
                formLogin.formdetail = this;
                formLogin.Show();
            }else
            {
                listOrder.Add(productID);
            }
            
        }

        private void btnAddwishlist_Click(object sender, EventArgs e)
        {

        }

        private void ProductDetail_Load(object sender, EventArgs e)
        {
            ProductContext db = new ProductContext();
            db.getByID(productID);
            
        }
    }
}
