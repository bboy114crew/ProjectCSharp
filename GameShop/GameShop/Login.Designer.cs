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
            this.label3 = new System.Windows.Forms.Label();
            this.btnNextSignUp = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSubmitRegister = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tbRegisterUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbResgisterRepassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panelBGRegister = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRegisterPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.labelSuccess = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSignup = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelRegister = new System.Windows.Forms.Label();
            this.panelBGLogin.SuspendLayout();
            this.panelBGRegister.SuspendLayout();
            this.panelInfo.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(57, 30);
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
            this.panelBGLogin.Controls.Add(this.labelSuccess);
            this.panelBGLogin.Controls.Add(this.labelError);
            this.panelBGLogin.Controls.Add(this.labelLogin);
            this.panelBGLogin.Controls.Add(this.label3);
            this.panelBGLogin.Controls.Add(this.btnNextSignUp);
            this.panelBGLogin.Controls.Add(this.btnLogin);
            this.panelBGLogin.Controls.Add(this.tbUsername);
            this.panelBGLogin.Controls.Add(this.label1);
            this.panelBGLogin.Controls.Add(this.tbPassword);
            this.panelBGLogin.Location = new System.Drawing.Point(422, 54);
            this.panelBGLogin.Name = "panelBGLogin";
            this.panelBGLogin.Size = new System.Drawing.Size(394, 457);
            this.panelBGLogin.TabIndex = 8;
            this.panelBGLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // btnNextSignUp
            // 
            this.btnNextSignUp.ActiveBorderThickness = 1;
            this.btnNextSignUp.ActiveCornerRadius = 20;
            this.btnNextSignUp.ActiveFillColor = System.Drawing.Color.Gray;
            this.btnNextSignUp.ActiveForecolor = System.Drawing.Color.White;
            this.btnNextSignUp.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btnNextSignUp.BackColor = System.Drawing.SystemColors.Control;
            this.btnNextSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNextSignUp.BackgroundImage")));
            this.btnNextSignUp.ButtonText = "Sign up";
            this.btnNextSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextSignUp.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNextSignUp.IdleBorderThickness = 1;
            this.btnNextSignUp.IdleCornerRadius = 20;
            this.btnNextSignUp.IdleFillColor = System.Drawing.Color.White;
            this.btnNextSignUp.IdleForecolor = System.Drawing.Color.DarkRed;
            this.btnNextSignUp.IdleLineColor = System.Drawing.Color.DarkRed;
            this.btnNextSignUp.Location = new System.Drawing.Point(221, 353);
            this.btnNextSignUp.Margin = new System.Windows.Forms.Padding(5);
            this.btnNextSignUp.Name = "btnNextSignUp";
            this.btnNextSignUp.Size = new System.Drawing.Size(107, 51);
            this.btnNextSignUp.TabIndex = 8;
            this.btnNextSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNextSignUp.Click += new System.EventHandler(this.bunifuThinButton22_Click);
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
            // btnSubmitRegister
            // 
            this.btnSubmitRegister.ActiveBorderThickness = 1;
            this.btnSubmitRegister.ActiveCornerRadius = 20;
            this.btnSubmitRegister.ActiveFillColor = System.Drawing.Color.Gray;
            this.btnSubmitRegister.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.btnSubmitRegister.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btnSubmitRegister.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubmitRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmitRegister.BackgroundImage")));
            this.btnSubmitRegister.ButtonText = "Continue";
            this.btnSubmitRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitRegister.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSubmitRegister.IdleBorderThickness = 1;
            this.btnSubmitRegister.IdleCornerRadius = 20;
            this.btnSubmitRegister.IdleFillColor = System.Drawing.Color.DarkRed;
            this.btnSubmitRegister.IdleForecolor = System.Drawing.Color.White;
            this.btnSubmitRegister.IdleLineColor = System.Drawing.Color.White;
            this.btnSubmitRegister.Location = new System.Drawing.Point(66, 367);
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
            this.panelBGRegister.Controls.Add(this.labelRegister);
            this.panelBGRegister.Controls.Add(this.btnCancel);
            this.panelBGRegister.Controls.Add(this.label2);
            this.panelBGRegister.Controls.Add(this.tbRegisterPassword);
            this.panelBGRegister.Controls.Add(this.tbResgisterRepassword);
            this.panelBGRegister.Controls.Add(this.btnSubmitRegister);
            this.panelBGRegister.Controls.Add(this.tbRegisterUsername);
            this.panelBGRegister.Location = new System.Drawing.Point(12, 54);
            this.panelBGRegister.Name = "panelBGRegister";
            this.panelBGRegister.Size = new System.Drawing.Size(394, 457);
            this.panelBGRegister.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(58, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 46);
            this.label2.TabIndex = 12;
            this.label2.Text = "    Register";
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
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.ForeColor = System.Drawing.Color.Red;
            this.labelLogin.Location = new System.Drawing.Point(75, 332);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(0, 13);
            this.labelLogin.TabIndex = 10;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(66, 316);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.Gray;
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.White;
            this.btnCancel.IdleForecolor = System.Drawing.Color.DarkRed;
            this.btnCancel.IdleLineColor = System.Drawing.Color.DarkRed;
            this.btnCancel.Location = new System.Drawing.Point(233, 367);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 51);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = true;
            this.labelSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuccess.ForeColor = System.Drawing.Color.Lime;
            this.labelSuccess.Location = new System.Drawing.Point(66, 316);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(48, 17);
            this.labelSuccess.TabIndex = 12;
            this.labelSuccess.Text = "aaaaa";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.Control;
            this.panelInfo.Controls.Add(this.bunifuMaterialTextbox4);
            this.panelInfo.Controls.Add(this.bunifuThinButton21);
            this.panelInfo.Controls.Add(this.label4);
            this.panelInfo.Controls.Add(this.bunifuMaterialTextbox1);
            this.panelInfo.Controls.Add(this.bunifuMaterialTextbox2);
            this.panelInfo.Controls.Add(this.btnSignup);
            this.panelInfo.Controls.Add(this.bunifuMaterialTextbox3);
            this.panelInfo.Location = new System.Drawing.Point(842, 54);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(322, 457);
            this.panelInfo.TabIndex = 12;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Gray;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Cancel";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton21.Location = new System.Drawing.Point(195, 370);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(107, 51);
            this.bunifuThinButton21.TabIndex = 19;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(20, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 46);
            this.label4.TabIndex = 18;
            this.label4.Text = "    Register";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.DarkRed;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.bunifuMaterialTextbox1.LineThickness = 4;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(28, 164);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(274, 52);
            this.bunifuMaterialTextbox1.TabIndex = 17;
            this.bunifuMaterialTextbox1.Text = "Password";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.DarkRed;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.bunifuMaterialTextbox2.LineThickness = 4;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(28, 226);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(274, 52);
            this.bunifuMaterialTextbox2.TabIndex = 15;
            this.bunifuMaterialTextbox2.Text = "Password";
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSignup
            // 
            this.btnSignup.ActiveBorderThickness = 1;
            this.btnSignup.ActiveCornerRadius = 20;
            this.btnSignup.ActiveFillColor = System.Drawing.Color.Gray;
            this.btnSignup.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.btnSignup.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btnSignup.BackColor = System.Drawing.SystemColors.Control;
            this.btnSignup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignup.BackgroundImage")));
            this.btnSignup.ButtonText = "Sign up";
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSignup.IdleBorderThickness = 1;
            this.btnSignup.IdleCornerRadius = 20;
            this.btnSignup.IdleFillColor = System.Drawing.Color.DarkRed;
            this.btnSignup.IdleForecolor = System.Drawing.Color.White;
            this.btnSignup.IdleLineColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(28, 370);
            this.btnSignup.Margin = new System.Windows.Forms.Padding(5);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(119, 51);
            this.btnSignup.TabIndex = 16;
            this.btnSignup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox3.HintText = "";
            this.bunifuMaterialTextbox3.isPassword = false;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.DarkRed;
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.bunifuMaterialTextbox3.LineThickness = 4;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(28, 102);
            this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(274, 52);
            this.bunifuMaterialTextbox3.TabIndex = 14;
            this.bunifuMaterialTextbox3.Text = "Username";
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox4
            // 
            this.bunifuMaterialTextbox4.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox4.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.bunifuMaterialTextbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox4.HintText = "";
            this.bunifuMaterialTextbox4.isPassword = false;
            this.bunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.bunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.DarkRed;
            this.bunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.bunifuMaterialTextbox4.LineThickness = 4;
            this.bunifuMaterialTextbox4.Location = new System.Drawing.Point(28, 293);
            this.bunifuMaterialTextbox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
            this.bunifuMaterialTextbox4.Size = new System.Drawing.Size(274, 52);
            this.bunifuMaterialTextbox4.TabIndex = 20;
            this.bunifuMaterialTextbox4.Text = "Password";
            this.bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.ForeColor = System.Drawing.Color.Red;
            this.labelRegister.Location = new System.Drawing.Point(63, 328);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(48, 17);
            this.labelRegister.TabIndex = 14;
            this.labelRegister.Text = "aaaaa";
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1163, 630);
            this.Controls.Add(this.panelInfo);
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
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBGLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNextSignUp;
        private System.Windows.Forms.Panel panelBGRegister;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbResgisterRepassword;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSubmitRegister;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbRegisterUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbRegisterPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private System.Windows.Forms.Label labelSuccess;
        private System.Windows.Forms.Panel panelInfo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox4;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSignup;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        private System.Windows.Forms.Label labelRegister;
    }
}