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
        public ListAll()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        int id;
        private void ListAll_Load(object sender, EventArgs e)
        {
            ProductContext productContext = new ProductContext();
            List<Products> products = productContext.getByCategoryID(id);
            int row = products.Count % 5;
            int indexPl1 = 0;
            for (int i = 0; i < row; i++)
            {               
                Panel pl2 = new Panel();
                pl2.BackColor = Color.White;
                pl2.Size = new Size(985, 172);
                pl2.Location = new Point(6, 37);

                int indexPl2 = 1;
                for (int j = 0; j < products.Count; j++)
                {
                    Button btn1 = new Button();
                    btn1.FlatStyle = FlatStyle.Flat;
                    btn1.Text += "button";
                    btn1.Size = new Size(192, 180);
                    btn1.Location = new Point(indexPl2, 0);
                    btn1.FlatAppearance.BorderSize = 0;
                    //Image myimage = new Bitmap(@folderImgPath()+@"Image\nier\pic5.jpg");
                    Image myimage = new Bitmap(@"C:\Users\Jic\Desktop\Image\ds3\pic1.jpg");
                    btn1.BackgroundImage = myimage;
                    btn1.BackgroundImageLayout = ImageLayout.Stretch;

                    pl2.Controls.Add(btn1);
                    if (j % 5 == 0) {
                        indexPl2 += 198;

                    }
                }


                Panel pl1 = new Panel();
                pl1.BackColor = Color.CornflowerBlue;
                pl1.Size = new Size(997, 223);
                pl1.Location = new Point(0, indexPl1);

                pl1.Controls.Add(pl2);

                pnAll.Controls.Add(pl1);
                indexPl1 += 229;
            }
        }
    }
}
