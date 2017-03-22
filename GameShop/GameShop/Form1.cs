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
            Console.WriteLine(folderImgPath());
            pnUserInfo.Width = 40;
            pnControlBtnInfo.Visible = false;

            int indexPl1 = 0;
           
            for (int i = 0; i < 10; i++)
            {
                Label lb = new Label();
                lb.Text = "Category";
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

                int indexPl2 = 1;
                for (int j = 0; j < 5; j++)
                {
                    Button btn1 = new Button();
                    btn1.FlatStyle = FlatStyle.Flat;
                    btn1.Text += "button";
                    btn1.Size = new Size(192, 180);
                    btn1.Location = new Point(indexPl2, 0);
                    btn1.FlatAppearance.BorderSize = 0;
                    Image myimage = new Bitmap(@folderImgPath()+@"Image\nier\pic5.jpg");
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
