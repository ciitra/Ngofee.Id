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
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"
                    INSERT INTO users(username, password, email, no_telepon, role, created_at)
                    VALUES(@username, @password, @email, @no_telepon, @role, NOW())";

                    string hashPassword = PasswordHelper.HashPassword(user.Password);

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@password", hashPassword);
                        cmd.Parameters.AddWithValue("@email", user.Email);
                        cmd.Parameters.AddWithValue("@no_telepon", user.NoTelepon);
                        cmd.Parameters.AddWithValue("@role",user.Role.ToString());

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Register ERROR: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}