namespace GameShop
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tbUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBGLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSubmitRegister = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tbRegisterUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbResgisterRepassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panelBGRegister = new System.Windows.Forms.Panel();
            this.tbRegisterPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelBGLogin.SuspendLayout();
            this.panelBGRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.SystemColors.Control;
            this.tbUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUsername.HintForeColor = System.Drawing.Color.Empty;
            this.tbUsername.HintText = "";
            this.tbUsername.isPassword = false;
            this.tbUsername.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.tbUsername.LineIdleColor = System.Drawing.Color.DarkRed;
            this.tbUsername.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.tbUsername.LineThickness = 4;
            this.tbUsername.Location = new System.Drawing.Point(66, 127);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(262, 52);
            this.tbUsername.TabIndex = 2;
            this.tbUsername.Text = "Username";
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUsername.OnValueChanged += new System.EventHandler(this.tbUsername_OnValueChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.Control;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPassword.HintForeColor = System.Drawing.Color.Empty;
            this.tbPassword.HintText = "";
            this.tbPassword.isPassword = true;
            this.tbPassword.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.tbPassword.LineIdleColor = System.Drawing.Color.DarkRed;
            this.tbPassword.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.tbPassword.LineThickness = 4;
            this.tbPassword.Location = new System.Drawing.Point(66, 220);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(262, 52);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.Text = "Password";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPassword.OnValueChanged += new System.EventHandler(this.tbPassword_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(113, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "   Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelBGLogin
            // 
            this.panelBGLogin.BackColor = System.Drawing.SystemColors.Control;
            this.panelBGLogin.Controls.Add(this.label3);
            this.panelBGLogin.Controls.Add(this.bunifuThinButton22);
            this.panelBGLogin.Controls.Add(this.btnLogin);
            this.panelBGLogin.Controls.Add(this.tbUsername);
            this.panelBGLogin.Controls.Add(this.label1);
            this.panelBGLogin.Controls.Add(this.tbPassword);
            this.panelBGLogin.Location = new System.Drawing.Point(107, 99);
            this.panelBGLogin.Name = "panelBGLogin";
            this.panelBGLogin.Size = new System.Drawing.Size(394, 457);
            this.panelBGLogin.TabIndex = 8;
            this.panelBGLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.Gray;
            this.btnLogin.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.DarkRed;
            this.btnLogin.IdleForecolor = System.Drawing.Color.White;
            this.btnLogin.IdleLineColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(66, 353);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(119, 51);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Gray;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Sign up";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton22.Location = new System.Drawing.Point(221, 353);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(107, 51);
            this.bunifuThinButton22.TabIndex = 8;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // btnSubmitRegister
            // 
            this.btnSubmitRegister.ActiveBorderThickness = 1;
            this.btnSubmitRegister.ActiveCornerRadius = 20;
            this.btnSubmitRegister.ActiveFillColor = System.Drawing.Color.Gray;
            this.btnSubmitRegister.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.btnSubmitRegister.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btnSubmitRegister.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubmitRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmitRegister.BackgroundImage")));
            this.btnSubmitRegister.ButtonText = "Sign up";
            this.btnSubmitRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitRegister.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSubmitRegister.IdleBorderThickness = 1;
            this.btnSubmitRegister.IdleCornerRadius = 20;
            this.btnSubmitRegister.IdleFillColor = System.Drawing.Color.DarkRed;
            this.btnSubmitRegister.IdleForecolor = System.Drawing.Color.White;
            this.btnSubmitRegister.IdleLineColor = System.Drawing.Color.White;
            this.btnSubmitRegister.Location = new System.Drawing.Point(66, 340);
            this.btnSubmitRegister.Margin = new System.Windows.Forms.Padding(5);
            this.btnSubmitRegister.Name = "btnSubmitRegister";
            this.btnSubmitRegister.Size = new System.Drawing.Size(119, 51);
            this.btnSubmitRegister.TabIndex = 10;
            this.btnSubmitRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubmitRegister.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // tbRegisterUsername
            // 
            this.tbRegisterUsername.BackColor = System.Drawing.SystemColors.Control;
            this.tbRegisterUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRegisterUsername.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tbRegisterUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbRegisterUsername.HintForeColor = System.Drawing.Color.Empty;
            this.tbRegisterUsername.HintText = "";
            this.tbRegisterUsername.isPassword = false;
            this.tbRegisterUsername.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.tbRegisterUsername.LineIdleColor = System.Drawing.Color.DarkRed;
            this.tbRegisterUsername.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.tbRegisterUsername.LineThickness = 4;
            this.tbRegisterUsername.Location = new System.Drawing.Point(66, 99);
            this.tbRegisterUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbRegisterUsername.Name = "tbRegisterUsername";
            this.tbRegisterUsername.Size = new System.Drawing.Size(274, 52);
            this.tbRegisterUsername.TabIndex = 8;
            this.tbRegisterUsername.Text = "Username";
            this.tbRegisterUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbRegisterUsername.OnValueChanged += new System.EventHandler(this.tbRegisterUsername_OnValueChanged);
            // 
            // tbResgisterRepassword
            // 
            this.tbResgisterRepassword.BackColor = System.Drawing.SystemColors.Control;
            this.tbResgisterRepassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbResgisterRepassword.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tbResgisterRepassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbResgisterRepassword.HintForeColor = System.Drawing.Color.Empty;
            this.tbResgisterRepassword.HintText = "";
            this.tbResgisterRepassword.isPassword = true;
            this.tbResgisterRepassword.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.tbResgisterRepassword.LineIdleColor = System.Drawing.Color.DarkRed;
            this.tbResgisterRepassword.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.tbResgisterRepassword.LineThickness = 4;
            this.tbResgisterRepassword.Location = new System.Drawing.Point(66, 245);
            this.tbResgisterRepassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbResgisterRepassword.Name = "tbResgisterRepassword";
            this.tbResgisterRepassword.Size = new System.Drawing.Size(274, 52);
            this.tbResgisterRepassword.TabIndex = 9;
            this.tbResgisterRepassword.Text = "Password";
            this.tbResgisterRepassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelBGRegister
            // 
            this.panelBGRegister.BackColor = System.Drawing.SystemColors.Control;
            this.panelBGRegister.Controls.Add(this.label2);
            this.panelBGRegister.Controls.Add(this.tbRegisterPassword);
            this.panelBGRegister.Controls.Add(this.tbResgisterRepassword);
            this.panelBGRegister.Controls.Add(this.btnSubmitRegister);
            this.panelBGRegister.Controls.Add(this.tbRegisterUsername);
            this.panelBGRegister.Location = new System.Drawing.Point(12, 303);
            this.panelBGRegister.Name = "panelBGRegister";
            this.panelBGRegister.Size = new System.Drawing.Size(394, 457);
            this.panelBGRegister.TabIndex = 11;
            // 
            // tbRegisterPassword
            // 
            this.tbRegisterPassword.BackColor = System.Drawing.SystemColors.Control;
            this.tbRegisterPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRegisterPassword.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tbRegisterPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbRegisterPassword.HintForeColor = System.Drawing.Color.Empty;
            this.tbRegisterPassword.HintText = "";
            this.tbRegisterPassword.isPassword = true;
            this.tbRegisterPassword.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.tbRegisterPassword.LineIdleColor = System.Drawing.Color.DarkRed;
            this.tbRegisterPassword.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.tbRegisterPassword.LineThickness = 4;
            this.tbRegisterPassword.Location = new System.Drawing.Point(66, 174);
            this.tbRegisterPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbRegisterPassword.Name = "tbRegisterPassword";
            this.tbRegisterPassword.Size = new System.Drawing.Size(274, 52);
            this.tbRegisterPassword.TabIndex = 11;
            this.tbRegisterPassword.Text = "Password";
            this.tbRegisterPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(66, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 46);
            this.label2.TabIndex = 12;
            this.label2.Text = "    Register";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(72, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(602, 630);
            this.Controls.Add(this.panelBGRegister);
            this.Controls.Add(this.panelBGLogin);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelBGLogin.ResumeLayout(false);
            this.panelBGLogin.PerformLayout();
            this.panelBGRegister.ResumeLayout(false);
            this.panelBGRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBGLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.Panel panelBGRegister;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbResgisterRepassword;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSubmitRegister;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbRegisterUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbRegisterPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}