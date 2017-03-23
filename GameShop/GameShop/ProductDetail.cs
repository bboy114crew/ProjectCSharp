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
            }
            else
            {
                if (SessionOrder.getOrders.GetOrderList.Count == 0)
                {
                    SessionOrder.getOrders.GetOrderList.Add(new OrderDetail(0, SessionOrder.productId, 1, 12));
                }
                else
                {
                    for (int i = 0; i < SessionOrder.getOrders.GetOrderList.Count; i++ )
                    {
                        OrderDetail ol = SessionOrder.getOrders.GetOrderList[i];
                        if (ol.ProductID == SessionOrder.productId)
                        {
                            
                            ol.Quantity += 1;
                        }
                        else
                        {
                            SessionOrder.getOrders.GetOrderList.Add(new OrderDetail(0, SessionOrder.productId, 1, 12));
                        }
                    }
                }
                lbNumber.Text = (Convert.ToInt16(lbNumber.Text) + 1) + "";
            }
            
        }
        private void ProductDetail_Load(object sender, EventArgs e)
        {
            lbNumber.Text = SessionOrder.countBasket + "";

            ProductContext db = new ProductContext();
            ImageContext im = new ImageContext();
            Products p = db.getByID(SessionOrder.productId);
            Image myimage = new Bitmap(@"C:\Users\Jic\Desktop\" + @im.getByProductID1(SessionOrder.productId)[0].url);
            panelUrl1.BackgroundImage = myimage;
            panelUrl1.BackgroundImageLayout = ImageLayout.Stretch;
            Image myimage1 = new Bitmap(@"C:\Users\Jic\Desktop\" + @im.getByProductID1(SessionOrder.productId)[1].url);
            panelUrl2.BackgroundImage = myimage1;
            panelUrl2.BackgroundImageLayout = ImageLayout.Stretch;
            Image myimage2 = new Bitmap(@"C:\Users\Jic\Desktop\" + @im.getByProductID1(SessionOrder.productId)[2].url);
            panelUrl3.BackgroundImage = myimage2;
            panelUrl3.BackgroundImageLayout = ImageLayout.Stretch;

            labelName.Text = p.name;
            labelPrice.Text = p.price + "$";
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(lbNumber.Text) > 0)
            {
                Basket form = new Basket();
                form.Show();
            }
            
        }

        private void ProductDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionOrder.countBasket = Convert.ToInt16(lbNumber.Text);
        }
    }
}
