using Ngofee.Id.Database;
using Ngofee.Id.Helpers;
using Ngofee.Id.Models;
using Npgsql;
using System.Drawing.Text;

namespace Ngofee.Id.Controllers
{
    public class AuthController
    {
        private DbContext _dbContext;

        public AuthController()
        {
            _dbContext = new DbContext();
        }

        public UserModel Login(UserModel user)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"
                        SELECT user_id, role, username, password, email, no_telepon FROM users 
                        WHERE username = @username AND password = @password LIMIT 1";


                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        string hashedPassword = PasswordHelper.HashPassword(user.Password);

                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);

                        using (var read = cmd.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                int userId = read.GetInt32(0);
                                string role = read.GetString(1);
                                UserRole roleEnum = (UserRole)Enum.Parse(typeof(UserRole), role);

                                UserModel loggedInuser = new UserModel
                                {
                                    UserId = userId,
                                    Role = roleEnum,
                                    Username = read.GetString(2),
                                    Password = hashedPassword,
                                    Email = read.GetString(4),
                                    NoTelepon = read.GetString(5)
                                };

                                return loggedInuser;
                            }

                            return null;

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"LOGIN ERROR: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public bool Register(UserModel user)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();

                    // CEK USERNAME SUDAH ADA
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
                    using (var checkCmd = new NpgsqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@username", user.Username);
                        long count = (long)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Username sudah digunakan!");
                            return false;
                        }
                    }

                    // HASH PASSWORD
                    string hashedPassword = PasswordHelper.HashPassword(user.Password);

                    // INSERT DATA
                    string query = @"
                INSERT INTO users(username, password, email, no_telepon, role) 
                VALUES (@username, @password, @mail, @telp, @role)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@mail", user.Email);
                        cmd.Parameters.AddWithValue("@telp", user.NoTelepon);
                        cmd.Parameters.AddWithValue("@role", user.Role.ToString());

                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Register ERROR: " + ex.Message);
                return false;
            }
        }
    }
}