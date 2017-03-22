using GameShop.DAL;
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
        static bool validate(string username)
        {
            if (username.Length < 6 || username.Length > 32)
                return false;
            foreach(char word in username)
            {
                if ((word < 48) || (word > 56 && word < 65) || (word > 90 && word < 97) || word > 122)
                    return false;
            }
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if(validate(tbUsername.Text) && validate(tbPassword.Text))
            {
                if (!AccountDB.GetAccountByUsername(tbUsername.Text, tbPassword.Text))
                {
                    tbUsername.Select();
                    labelError.Text = "Username or Password is not true";
                }
                else
                {
                    this.Close();
                }
            }else
            {
                labelError.Text = "Username or Password is not true.";
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (validate(tbRegisterUsername.Text) && validate(tbRegisterPassword.Text))
            {
                if (!tbRegisterPassword.Text.Equals(tbResgisterRepassword.Text))
                {

                }
            }
            else
            {

            }

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
        private void tbUsername_Click(object sender, EventArgs e)
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

        private void btnSignup_Click(object sender, EventArgs e)
        {

        }
    }
    
}
