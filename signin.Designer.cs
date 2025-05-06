namespace authentication
{
    partial class signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signin));
            this.imgFavicon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.pnlOne = new System.Windows.Forms.Panel();
            this.imgPassword = new System.Windows.Forms.PictureBox();
            this.btnSignin = new System.Windows.Forms.Button();
            this.lblPulisci = new System.Windows.Forms.Label();
            this.btnEsci = new System.Windows.Forms.Label();
            this.pnlTwo = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgFavicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // imgFavicon
            // 
            this.imgFavicon.Image = global::Authentication.Properties.Resources.logo_192;
            this.imgFavicon.Location = new System.Drawing.Point(103, 48);
            this.imgFavicon.Name = "imgFavicon";
            this.imgFavicon.Size = new System.Drawing.Size(87, 71);
            this.imgFavicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFavicon.TabIndex = 1;
            this.imgFavicon.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Orange;
            this.lblTitle.Location = new System.Drawing.Point(97, 133);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(114, 36);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "SIGNIN";
            // 
            // imgUser
            // 
            this.imgUser.Image = global::Authentication.Properties.Resources.user;
            this.imgUser.Location = new System.Drawing.Point(42, 201);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(35, 28);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUser.TabIndex = 3;
            this.imgUser.TabStop = false;
            // 
            // pnlOne
            // 
            this.pnlOne.BackColor = System.Drawing.Color.Orange;
            this.pnlOne.Location = new System.Drawing.Point(42, 235);
            this.pnlOne.Name = "pnlOne";
            this.pnlOne.Size = new System.Drawing.Size(235, 1);
            this.pnlOne.TabIndex = 4;
            // 
            // imgPassword
            // 
            this.imgPassword.Image = global::Authentication.Properties.Resources.password;
            this.imgPassword.Location = new System.Drawing.Point(42, 274);
            this.imgPassword.Name = "imgPassword";
            this.imgPassword.Size = new System.Drawing.Size(35, 28);
            this.imgPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPassword.TabIndex = 5;
            this.imgPassword.TabStop = false;
            // 
            // btnSignin
            // 
            this.btnSignin.BackColor = System.Drawing.Color.Orange;
            this.btnSignin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignin.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.ForeColor = System.Drawing.Color.White;
            this.btnSignin.Location = new System.Drawing.Point(42, 340);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(235, 34);
            this.btnSignin.TabIndex = 4;
            this.btnSignin.Text = "SIGNIN";
            this.btnSignin.UseVisualStyleBackColor = false;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // lblPulisci
            // 
            this.lblPulisci.AutoSize = true;
            this.lblPulisci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPulisci.ForeColor = System.Drawing.Color.Orange;
            this.lblPulisci.Location = new System.Drawing.Point(176, 321);
            this.lblPulisci.Name = "lblPulisci";
            this.lblPulisci.Size = new System.Drawing.Size(101, 16);
            this.lblPulisci.TabIndex = 3;
            this.lblPulisci.Text = "Pulisci Campi";
            this.lblPulisci.Click += new System.EventHandler(this.lblPulisci_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.AutoSize = true;
            this.btnEsci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsci.ForeColor = System.Drawing.Color.Orange;
            this.btnEsci.Location = new System.Drawing.Point(139, 387);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(37, 16);
            this.btnEsci.TabIndex = 5;
            this.btnEsci.Text = "Esci";
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // pnlTwo
            // 
            this.pnlTwo.BackColor = System.Drawing.Color.Orange;
            this.pnlTwo.Location = new System.Drawing.Point(42, 308);
            this.pnlTwo.Name = "pnlTwo";
            this.pnlTwo.Size = new System.Drawing.Size(235, 1);
            this.pnlTwo.TabIndex = 9;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Orange;
            this.txtUsername.Location = new System.Drawing.Point(83, 212);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(194, 17);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Orange;
            this.txtPassword.Location = new System.Drawing.Point(83, 285);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(194, 17);
            this.txtPassword.TabIndex = 2;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Orange;
            this.lblLogin.Location = new System.Drawing.Point(39, 321);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(45, 16);
            this.lblLogin.TabIndex = 10;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(302, 425);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pnlTwo);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.lblPulisci);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.imgPassword);
            this.Controls.Add(this.pnlOne);
            this.Controls.Add(this.imgUser);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.imgFavicon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(97, 133);
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register";
            ((System.ComponentModel.ISupportInitialize)(this.imgFavicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgFavicon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.Panel pnlOne;
        private System.Windows.Forms.PictureBox imgPassword;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.Label lblPulisci;
        private System.Windows.Forms.Label btnEsci;
        private System.Windows.Forms.Panel pnlTwo;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblLogin;
    }
}