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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnUserInfo.Width = 40;
            pnControlBtnInfo.Visible = false;
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
