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
    public partial class ListAll : Form
    {
        public int id;
        public ListAll(int pid)
        {
            id = pid;
            InitializeComponent();
        }

        private void ListAll_Load(object sender, EventArgs e)
        {
            ProductContext productContext = new ProductContext();
            List<Products> products = productContext.getByCategoryID(id);
            ImageContext imageContext = new ImageContext();

            int indexPl1X = 5;
            int indexPl1Y = 0;
            for (int i = 0; i < products.Count; i++)
            {
                Button btn1 = new Button();
                btn1.FlatStyle = FlatStyle.Flat;
                btn1.Size = new Size(130, 130);
                btn1.Location = new Point(indexPl1X, indexPl1Y);
                btn1.FlatAppearance.BorderSize = 0;
                btn1.Click += btnImg_Click;
                btn1.Name = products[i].id + "";
                //Image myimage = new Bitmap(@folderImgPath()+@"Image\nier\pic5.jpg");
                Images img = imageContext.getByProductID(products[i].id);
                Image myimage = new Bitmap(@"C:\Users\Jic\Desktop\" + @img.url);
                btn1.BackgroundImage = myimage;
                btn1.BackgroundImageLayout = ImageLayout.Stretch;

                if (i % 5 == 0 && i != 0)
                {
                    indexPl1Y += 130;
                }
                pnContentImg.Controls.Add(btn1);
                indexPl1X += 135;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ProductDetail form = new ProductDetail();
            SessionOrder.productId = Convert.ToInt16(btn.Name);
            form.Show();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            CategoryContext categoryContext = new CategoryContext();
            ProductContext productContext = new ProductContext();
            ImageContext imageContext = new ImageContext();

            List<Products> products = productContext.searchProduct(tbSearch.Text, id);

            if (products.Count > 0)
            {
                pnContentImg.Controls.Clear();
                pnContentImg.Invalidate();
                pnContentImg.Refresh();

                int indexPl1X = 5;
                int indexPl1Y = 0;
                for (int i = 0; i < products.Count; i++)
                {
                    Button btn1 = new Button();
                    btn1.FlatStyle = FlatStyle.Flat;
                    btn1.Size = new Size(130, 130);
                    btn1.Location = new Point(indexPl1X, indexPl1Y);
                    btn1.FlatAppearance.BorderSize = 0;

                    //Image myimage = new Bitmap(@folderImgPath()+@"Image\nier\pic5.jpg");
                    Images img = imageContext.getByProductID(products[i].id);
                    Image myimage = new Bitmap(@"C:\Users\Jic\Desktop\" + @img.url);
                    btn1.BackgroundImage = myimage;
                    btn1.BackgroundImageLayout = ImageLayout.Stretch;

                    if (i % 5 == 0 && i != 0)
                    {
                        indexPl1Y += 130;
                    }
                    pnContentImg.Controls.Add(btn1);
                    indexPl1X += 135;
                }
            }  
        }
    }
}
