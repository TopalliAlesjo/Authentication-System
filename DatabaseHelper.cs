using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Authentication
{
    internal class DatabaseHelper
    {
        private static readonly string ConnectionString = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Database.accdb";

        // Connessione al database
        private static OleDbConnection GetConnection()
        {
            return new OleDbConnection(ConnectionString);
        }

        // Verifica se l'utente esiste nel database
        public static bool UserExists(string username)
        {
            using (var cn = GetConnection())
            {
                cn.Open();
                var query = "SELECT [User] " +
                    "FROM Users " +
                    "WHERE [User] = @username";
                using (var cmd = new OleDbCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@username", username.ToLower());
                    using (var reader = cmd.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }

        // Aggiungi un nuovo utente al database
        public static bool RegisterUser(string username, string passwordHash)
        {
            using (var cn = GetConnection())
            {
                cn.Open();
                var query = "INSERT INTO Users ([User], [Password]) " +
                    "VALUES (@username, @password)";
                using (var cmd = new OleDbCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@username", username.ToLower());
                    cmd.Parameters.AddWithValue("@password", passwordHash);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Verifica login dell'utente
        public static bool VerifyLogin(string username, string passwordHash)
        {
            using (var cn = GetConnection())
            {
                cn.Open();
                var query = "SELECT [Password] " +
                    "FROM Users " +
                    "WHERE [User] = @username";
                using (var cmd = new OleDbCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@username", username.ToLower());
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["Password"].ToString() == passwordHash;
                        }
                    }
                }
            }
            return false;
        }
    }
}
