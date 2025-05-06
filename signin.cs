using Authentication;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace authentication
{

    public partial class signin : Form
    {

        public signin()
        {
            InitializeComponent();

            // Imposta il tasto predefinito del form
            this.AcceptButton = btnSignin;

            // Aggiunge un gestore eventi per il tasto Invio
            this.KeyDown += Register_KeyDown;
        }

        private void Register_KeyDown(object sender, KeyEventArgs e)
        {
            // in caso l'utente voglia inviare con INVIO è possibile
            if (e.KeyCode == Keys.Enter)
            {
                btnSignin.PerformClick();
            }
        }
        private void btnSignin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text.Trim();
            string Password = txtPassword.Text.Trim();

            // Controlli base
            if (!Security.Control(Username, Password))
            {
                txtUsername.Focus();
                return;
            }

            try
            {
                // Verifica se l'utente esiste
                if (DatabaseHelper.UserExists(Username))
                {
                    MessageBox.Show("Errore, Utente già esistente!");
                    txtUsername.Focus();
                    return;
                }

                // Hash della password
                string hashedPassword = Security.HashPassword(Password);

                // Aggiungi l'utente al database
                bool isUserRegistered = DatabaseHelper.RegisterUser(Username, hashedPassword);

                if (isUserRegistered)
                {
                    MessageBox.Show("Utente Registrato con successo!");
                    this.Close();
                    Login login = new Login();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Errore nella registrazione, per favore contatta il master developer dell'applicazione.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
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

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
}
