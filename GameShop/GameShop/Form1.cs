using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameShop.DAL;
using GameShop.Model;

namespace GameShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CategoryContext categoryContext = new CategoryContext();
            List<Categories> categorieses = categoryContext.getAll();
            ProductContext productContext = new ProductContext();
            ImageContext imageContext = new ImageContext();
            


            pnUserInfo.Width = 40;
            pnControlBtnInfo.Visible = false;

            int indexPl1 = 0;
           
            for (int i = 0; i < categorieses.Count; i++)
            {
                Label lb = new Label();
                lb.Text = categorieses[i].name;
                lb.Size = new Size(49, 13);
                lb.Location = new Point(6, 9);

                Button btn = new Button();
                btn.FlatStyle = FlatStyle.Flat;
                btn.Text += "Show all";
                btn.Size = new Size(75, 22);
                btn.Location = new Point(900, 9);

                Panel pl2 = new Panel();
                pl2.BackColor = Color.White;
                pl2.Size = new Size(985, 172);
                pl2.Location = new Point(6, 37);

                List<Products> productses = productContext.getByCategoryID(categorieses[i].id);
                Console.WriteLine(productses[i].id);

                int indexPl2 = 1;
                for (int j = 0; j < productses.Count; j++)
                {
                    Images img = imageContext.getByProductID(productses[j].id);

                    Console.WriteLine(img.url);


                    Button btn1 = new Button();
                    btn1.FlatStyle = FlatStyle.Flat;
                    btn1.Text = productses[j].name;
                    btn1.ForeColor = Color.White;
                    btn1.TextAlign = ContentAlignment.BottomCenter;
                    btn1.Size = new Size(192, 169);
                    btn1.Location = new Point(indexPl2, 0);
                    btn1.FlatAppearance.BorderSize = 0;
                    //Image myimage = new Bitmap(@folderImgPath()+@"Image\nier\pic5.jpg");
                    Image myimage = new Bitmap(@"C:\Users\Jic\Desktop\" + @img.url);
                    btn1.BackgroundImage = myimage;
                    btn1.BackgroundImageLayout = ImageLayout.Stretch;

                    pl2.Controls.Add(btn1);
                    indexPl2 += 198;
             
                }


                Panel pl1 = new Panel();
                pl1.BackColor = Color.CornflowerBlue;
                pl1.Size = new Size(997, 223);
                pl1.Location = new Point(0, indexPl1);
                pl1.Controls.Add(lb);
                pl1.Controls.Add(btn);
                pl1.Controls.Add(pl2);

                pnShowProduct.Controls.Add(pl1);
                indexPl1 += 229;   
            }
        }

        public string folderImgPath()
        {
            string fullPath = System.IO.Directory.GetCurrentDirectory();
            int index = fullPath.IndexOf("bin");
            return fullPath.Substring(0, index);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (pnUserInfo.Width == 40)
            {      
                pnUserInfo.Width = 340;
                pnControlBtnInfo.Visible = true;
            }
            else
            {
                pnUserInfo.Width = 40;
                pnControlBtnInfo.Visible = false;
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
