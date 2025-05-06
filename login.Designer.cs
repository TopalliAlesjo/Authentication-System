namespace authentication
{
    partial class Login
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblTilte = new System.Windows.Forms.Label();
            this.pnlOne = new System.Windows.Forms.Panel();
            this.pnlTwo = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPulisci = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnEsci = new System.Windows.Forms.Label();
            this.lblSignin = new System.Windows.Forms.Label();
            this.imgPassword = new System.Windows.Forms.PictureBox();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.imgFavicon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFavicon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTilte
            // 
            this.lblTilte.AutoSize = true;
            this.lblTilte.BackColor = System.Drawing.Color.White;
            this.lblTilte.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTilte.ForeColor = System.Drawing.Color.Orange;
            this.lblTilte.Location = new System.Drawing.Point(97, 133);
            this.lblTilte.Name = "lblTilte";
            this.lblTilte.Size = new System.Drawing.Size(105, 36);
            this.lblTilte.TabIndex = 1;
            this.lblTilte.Text = "LOGIN";
            // 
            // pnlOne
            // 
            this.pnlOne.BackColor = System.Drawing.Color.Orange;
            this.pnlOne.Location = new System.Drawing.Point(42, 235);
            this.pnlOne.Name = "pnlOne";
            this.pnlOne.Size = new System.Drawing.Size(235, 1);
            this.pnlOne.TabIndex = 3;
            // 
            // pnlTwo
            // 
            this.pnlTwo.BackColor = System.Drawing.Color.Orange;
            this.pnlTwo.Location = new System.Drawing.Point(42, 308);
            this.pnlTwo.Name = "pnlTwo";
            this.pnlTwo.Size = new System.Drawing.Size(235, 1);
            this.pnlTwo.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Orange;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(42, 340);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(235, 34);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPulisci
            // 
            this.lblPulisci.AutoSize = true;
            this.lblPulisci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPulisci.ForeColor = System.Drawing.Color.Orange;
            this.lblPulisci.Location = new System.Drawing.Point(176, 321);
            this.lblPulisci.Name = "lblPulisci";
            this.lblPulisci.Size = new System.Drawing.Size(101, 16);
            this.lblPulisci.TabIndex = 4;
            this.lblPulisci.Text = "Pulisci Campi";
            this.lblPulisci.Click += new System.EventHandler(this.lblPulisci_Click);
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
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPassword.Location = new System.Drawing.Point(83, 285);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(194, 17);
            this.txtPassword.TabIndex = 2;
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
            // lblSignin
            // 
            this.lblSignin.AutoSize = true;
            this.lblSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignin.ForeColor = System.Drawing.Color.Orange;
            this.lblSignin.Location = new System.Drawing.Point(39, 321);
            this.lblSignin.Name = "lblSignin";
            this.lblSignin.Size = new System.Drawing.Size(50, 16);
            this.lblSignin.TabIndex = 6;
            this.lblSignin.Text = "Signin";
            this.lblSignin.Click += new System.EventHandler(this.lblSignin_Click);
            // 
            // imgPassword
            // 
            this.imgPassword.Image = global::Authentication.Properties.Resources.password;
            this.imgPassword.Location = new System.Drawing.Point(42, 274);
            this.imgPassword.Name = "imgPassword";
            this.imgPassword.Size = new System.Drawing.Size(35, 28);
            this.imgPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPassword.TabIndex = 2;
            this.imgPassword.TabStop = false;
            // 
            // imgUser
            // 
            this.imgUser.Image = global::Authentication.Properties.Resources.user;
            this.imgUser.Location = new System.Drawing.Point(42, 201);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(35, 28);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUser.TabIndex = 2;
            this.imgUser.TabStop = false;
            // 
            // imgFavicon
            // 
            this.imgFavicon.Image = global::Authentication.Properties.Resources.logo_192;
            this.imgFavicon.Location = new System.Drawing.Point(103, 48);
            this.imgFavicon.Name = "imgFavicon";
            this.imgFavicon.Size = new System.Drawing.Size(87, 71);
            this.imgFavicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFavicon.TabIndex = 0;
            this.imgFavicon.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(302, 425);
            this.Controls.Add(this.lblSignin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.lblPulisci);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnlTwo);
            this.Controls.Add(this.pnlOne);
            this.Controls.Add(this.imgPassword);
            this.Controls.Add(this.imgUser);
            this.Controls.Add(this.lblTilte);
            this.Controls.Add(this.imgFavicon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login page";
            ((System.ComponentModel.ISupportInitialize)(this.imgPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFavicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgFavicon;
        private System.Windows.Forms.Label lblTilte;
        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.Panel pnlOne;
        private System.Windows.Forms.PictureBox imgPassword;
        private System.Windows.Forms.Panel pnlTwo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPulisci;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label btnEsci;
        private System.Windows.Forms.Label lblSignin;
    }
}

