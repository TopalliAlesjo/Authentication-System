using Authentication;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace authentication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // Imposta il tasto predefinito del form
            this.AcceptButton = btnLogin;

            // Aggiunge un gestore eventi per il tasto Invio
            this.KeyDown += Login_KeyDown;
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            // in caso l'utente voglia inviare con INVIO è possibile
            if (e.KeyCode == Keys.Enter) 
            {
                btnLogin.PerformClick();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text.Trim();
            string Password = txtPassword.Text.Trim();

            // Controlli di base
            if (!Security.Control(Username, Password))
            {
                txtUsername.Focus();
                return;
            }

            try
            {
                // Hash della password inserita
                string hashedPassword = Security.HashPassword(Password);

                // Verifica se le credenziali sono corrette
                if (DatabaseHelper.VerifyLogin(Username, hashedPassword))
                {
                    MessageBox.Show("Login Riuscito!");
                    this.Hide();
                    frmApplication app = new frmApplication();
                    app.Show();
                }
                else
                {
                    MessageBox.Show("Password Errata!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore: {ex.Message}");
            }
        }
            

        private void lblSignin_Click(object sender, EventArgs e)
        {
            new signin().Show();
            this.Hide();
        }

        private void lblPulisci_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
