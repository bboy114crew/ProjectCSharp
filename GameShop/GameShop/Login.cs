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
            

        }
        public Form formdetail { get; set; }
        private void Login_Load(object sender, EventArgs e)
        {
            panelBGRegister.Visible = false;
            panelInfo.Visible = false;
            panelBGLogin.Visible = true;
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
                    labelError.Text = "Incorrect username or password";
                }
                else
                {
                    Label lb = (Label)formdetail.Controls["labelUsername"];
                    lb.Text = tbUsername.Text;
                    this.Close();
                }
            }else
            {
                if(!validate(tbUsername.Text))
                    labelError.Text = "Username is invalid";
                else
                {
                    labelError.Text = "Password is invalid";
                }
            }

        }
        
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (validate(tbRegisterUsername.Text) && validate(tbRegisterPassword.Text))
            {
                if (!tbRegisterPassword.Text.Equals(tbResgisterRepassword.Text))
                {
                    labelRegister.Text = "Repassword is not true ";
                }
                else
                {
                    panelBGRegister.Visible = false;
                    panelBGLogin.Visible = false;
                    panelInfo.Visible = true;
                    //if (AccountDB.duplicateAccount(tbRegisterUsername.Text))
                    //{
                    //    panelBGRegister.Visible = false;
                    //    panelBGLogin.Visible = false;
                    //    panelInfo.Visible = true;
                    //}
                    //else
                    //{
                    //    labelRegister.Text = "Account is exist";
                    //    this.tbRegisterUsername.Select();
                    //}
                }
                
            }
            else
            {
                if (!validate(tbRegisterUsername.Text))
                    labelRegister.Text = "Username is invalid";
                else 
                {
                    labelRegister.Text = "Password is invalid";
                }
            }

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
        private void tbPassword_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text.Equals("Password"))
                tbPassword.Text = "";
        }
        private void tbRegisterUsername_OnValueChanged(object sender, EventArgs e)
        {
            if (tbRegisterUsername.Text.Equals("Username"))
                tbRegisterUsername.Text = "";
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if(!tbCusname.Text.Equals("") && !tbMail.Text.Equals("")&& !tbPhone.Text.Equals("")&& !tbAddress.Text.Equals(""))
            {
                AccountDB.register(tbCusname.Text,tbMail.Text,tbAddress.Text,tbPhone.Text,tbRegisterUsername.Text,tbResgisterRepassword.Text);
                labelSuccess.Text = "Sign up successfully";
                tbUsername.Text = tbRegisterUsername.Text;
                tbRegisterUsername.Text = "Username";
                tbPassword.Text = tbRegisterPassword.Text;
                tbRegisterPassword.Text = "Password";
                tbResgisterRepassword.Text = "Password";
                tbCusname.Text = "Name";
                tbMail.Text = "Mail";
                tbAddress.Text = "Address";
                tbPhone.Text = "Phone";
                labelError.Text = "";
                labelRegister.Text = "";
                labelLogin.Text = "";
                this.Close();
            }else
            {
                label5.Text = "Fields is not blank";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelBGRegister.Visible = false;
            panelInfo.Visible = false;
            panelBGLogin.Visible = true;
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            panelBGRegister.Visible = false;
            panelInfo.Visible = false;
            panelBGLogin.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tbRegisterPassword_OnValueChanged(object sender, EventArgs e)
        {
            if (tbRegisterPassword.Text.Equals("Password"))
                tbRegisterPassword.Text = "";
        }

        private void tbResgisterRepassword_OnValueChanged(object sender, EventArgs e)
        {
            if (tbResgisterRepassword.Text.Equals("Password"))
                tbResgisterRepassword.Text = "";
        }

        private void tbPhone_OnValueChanged(object sender, EventArgs e)
        {
            if (tbPhone.Text.Equals("Phone"))
                tbPhone.Text = "";
        }

        private void tbCusname_OnValueChanged(object sender, EventArgs e)
        {
            if (tbCusname.Text.Equals("Name"))
                tbCusname.Text = "";
        }

        private void tbMail_OnValueChanged(object sender, EventArgs e)
        {
            if (tbMail.Text.Equals("Mail"))
                tbMail.Text = "";
        }

        private void tbAddress_OnValueChanged(object sender, EventArgs e)
        {
            if (tbAddress.Text.Equals("Address"))
                tbAddress.Text = "";
        }
    }

}
