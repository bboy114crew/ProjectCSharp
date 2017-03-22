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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            panelBGRegister.Visible = false;
            panelBGLogin.Visible = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            panelBGLogin.Visible = false;
            panelBGRegister.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool checkValid = true;
            if(tbUsername.Text.Length <=6 )
            {
                checkValid = false;
            }
            if (tbPassword.Text.Length <= 6 || tbPassword.Text.Length >= 32)
            {
                checkValid = false;
            }
            if (checkValid)
            {

            }
            

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {


        }



        private void label1_Click(object sender, EventArgs e)
        {
           
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tbUsername_OnValueChanged(object sender, EventArgs e)
        {
            if (tbUsername.Text.Equals("Username"))
                tbUsername.Text = "";
        }

        private void tbPassword_OnValueChanged(object sender, EventArgs e)
        {
            if (tbPassword.Text.Equals("Password"))
                tbPassword.Text = "";
        }

        private void tbRegisterUsername_OnValueChanged(object sender, EventArgs e)
        {
            
        }
    }
    
}
