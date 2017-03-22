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
            labelUsername.Text = SessionOrder.user;
            //
        }

        private void btnAddcart_Click(object sender, EventArgs e)
        {
            if (SessionOrder.user.Equals(""))
            {
                Login formLogin = new Login();
                formLogin.formdetail = this;
                formLogin.Show();
            }else
            {
                if(SessionOrder.getOrders.GetOrderList.Count == 0)
                {
                    SessionOrder.getOrders.GetOrderList.Add(new OrderDetail(0, SessionOrder.productId, 1, 12));
                }
                foreach(OrderDetail ol in SessionOrder.getOrders.GetOrderList)
                {
                    if(ol.ProductID == SessionOrder.productId)
                    {
                        ol.Quantity += 1;
                    }else
                    {
                        SessionOrder.getOrders.GetOrderList.Add(new OrderDetail(0, SessionOrder.productId, 1, 12));
                        label1.Text = SessionOrder.getOrders.GetOrderList.Count + "";
                    }
                }
            }

        }
        private void ProductDetail_Load(object sender, EventArgs e)
        {
            ProductContext db = new ProductContext();
            ImageContext im = new ImageContext();
            Products p = db.getByID(SessionOrder.productId);
            Image myimage = new Bitmap(@"C:\Users\TD Chien\Pictures\" + @im.getByProductID1(SessionOrder.productId)[0].url);
            panelUrl1.BackgroundImage = myimage;
            panelUrl1.BackgroundImageLayout = ImageLayout.Stretch;
            Image myimage1 = new Bitmap(@"C:\Users\TD Chien\Pictures\" + @im.getByProductID1(SessionOrder.productId)[1].url);
            panelUrl2.BackgroundImage = myimage1;
            panelUrl2.BackgroundImageLayout = ImageLayout.Stretch;
            Image myimage2 = new Bitmap(@"C:\Users\TD Chien\Pictures\" + @im.getByProductID1(SessionOrder.productId)[2].url);
            panelUrl3.BackgroundImage = myimage2;
            panelUrl3.BackgroundImageLayout = ImageLayout.Stretch;

            labelName.Text = p.name;
            labelPrice.Text = p.price+"$";
            labelSup.Text = p.suppliers.name;
            labelCategory.Text = p.categories.name;
            labelDes.Text = p.des;

        }



        private void btnAddwishlist_Click(object sender, EventArgs e)
        {
            if (labelUsername.Text.Equals(""))
            {
                Login formLogin = new Login();
                formLogin.formdetail = this;
                formLogin.Show();
            }
            else
            {
                SessionOrder.wishlist.Add(SessionOrder.productId);
            }
        }


        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Basket form = new Basket();
            form.Show();
        }

        private void btnWishlist_Click(object sender, EventArgs e)
        {
            Basket form = new Basket();
            form.Show();
        }
    }
}
