using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace authentication
{
    internal class Security
    {
        static public bool Control(string username,string password)
        {
            // controlli di sicurezza
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Attenzione, Inserire Username & Password per registrarsi!");
                return false;
            }
            foreach (char lettera in username.Trim())
            {
                if (lettera == '\'')
                {
                    MessageBox.Show("Attenzione, non sono accetti caratteri fuori dalle lettere e numeri.");
                    return false;
                }
            }
            return true;
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
