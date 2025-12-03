using Ngofee.Id.Database;
using Ngofee.Id.Helpers;
using Ngofee.Id.Iinterfaces;
using Ngofee.Id.Models;
using Npgsql;

namespace Ngofee.Id.Controllers
{
    public class AuthController : BaseController, IAuth
    {
        public AuthController() : base()
        {
        }

        public UserModel Login(UserModel user)
        {
            if (!ValidateLoginInput(user))
                return null;
            try
            {
                using (var conn = CreateConnection())
                {
                    conn.Open();

                    string hashedPassword = PasswordHelper.HashPassword(user.Password);

                    string query = @"
                        SELECT user_id, role, username, password, email, no_telepon 
                        FROM users 
                        WHERE username = @username AND password = @password
                        LIMIT 1";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);

                        using (var read = cmd.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                return MapUser(read, hashedPassword);
                            }
                        }
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"LOGIN ERROR: {ex.Message}");
                return null;
            }
        }
        public bool Register(UserModel user)
        {
            if (!ValidateRegisterInput(user))
                return false;
            try
            {
                using (var conn = CreateConnection())
                {
                    conn.Open();

                    if (IsUsernameExist(conn, user.Username))
                    {
                        MessageBox.Show("Username sudah digunakan!");
                        return false;
                    }

                    string hashedPassword = PasswordHelper.HashPassword(user.Password);

                    string query = @"
                        INSERT INTO users(username, password, email, no_telepon, role)
                        VALUES (@username, @password, @email, @telp, @role)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@email", user.Email);
                        cmd.Parameters.AddWithValue("@telp", user.NoTelepon);
                        cmd.Parameters.AddWithValue("@role", user.Role.ToString());

                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("REGISTER ERROR: " + ex.Message);
                return false;
            }
        }


        private bool IsUsernameExist(NpgsqlConnection conn, string username)
        {
            string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
            using (var cmd = new NpgsqlCommand(checkQuery, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                long count = (long)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private UserModel MapUser(NpgsqlDataReader read, string hashedPassword)
        {
            return new UserModel
            {
                UserId = read.GetInt32(0),
                Role = (UserRole)Enum.Parse(typeof(UserRole), read.GetString(1)),
                Username = read.GetString(2),
                Password = hashedPassword,
                Email = read.GetString(4),
                NoTelepon = read.GetString(5)
            };
        }

        private bool ValidateLoginInput(UserModel user)
        {
            if (string.IsNullOrWhiteSpace(user.Username) ||
                string.IsNullOrWhiteSpace(user.Password))
            {
                MessageBox.Show("Username dan password wajib diisi!");
                return false;
            }

            return true;
        }

        private bool ValidateRegisterInput(UserModel user)
        {
            if (string.IsNullOrWhiteSpace(user.Username) ||
                string.IsNullOrWhiteSpace(user.Password) ||
                string.IsNullOrWhiteSpace(user.Email))
            {
                MessageBox.Show("Semua field wajib diisi!");
                return false;
            }

            return true;
        }
    }
}
