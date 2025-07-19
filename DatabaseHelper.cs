using System;
using System.Data.SQLite;
using System.IO;

namespace Student_man
{
    public static class DatabaseHelper
    {
        private static string dbFile = "userdata.db";
        private static string connectionString = $"Data Source={dbFile};Version=3;";

        public static void InitializeDatabase()
        {
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    // Create the Register table if it doesn't exist
                    command.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Register (
                            ID INTEGER PRIMARY KEY AUTOINCREMENT,
                            UserName TEXT NOT NULL UNIQUE,
                            Password TEXT NOT NULL,
                            ConPassword TEXT NOT NULL,
                            CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
                        )";
                    command.ExecuteNonQuery();
                }
            }
        }

        public static bool RegisterUser(string username, string password, string conPassword)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO Register (UserName, Password, ConPassword) VALUES (@username, @password, @conpassword)";
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@conpassword", conPassword);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SQLiteException ex)
            {
                if (ex.Message.Contains("UNIQUE"))
                {
                    throw new Exception("Username already exists!");
                }
                throw;
            }
        }

        public static bool ValidateLogin(string username, string password)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT COUNT(*) FROM Register WHERE UserName = @username AND Password = @password";
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
} 