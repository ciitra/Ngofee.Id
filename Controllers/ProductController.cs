using Ngofee.Id.Database;
using Ngofee.Id.Helpers;
using Ngofee.Id.Iinterfaces;
using Ngofee.Id.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngofee.Id.Controllers
{
    public class ProductController : IProduct
    {
        private DbContext _dbContext;

        public ProductController()
        {
            _dbContext = new DbContext();
        }

        public void CreateProduct(Product product)
        {
            try
            {
                if (AppSession.CurrentUser == null)
                {
                    MessageBox.Show("User tidak terautentikasi. Silakan login terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (AppSession.CurrentUser.UserId <= 0)
                {
                    MessageBox.Show($"UserId tidak valid: {AppSession.CurrentUser.UserId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"INSERT INTO products(foto_produk, nama_produk, harga, stok, jenis_produk, kriteria_produk, user_id, created_at)
                    VALUES (@fotoProduk, @namaProduk, @harga, @stok, @jenisProduk, @kriteriaProduk, @userId, NOW())";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fotoProduk", product.FotoProduk);
                        cmd.Parameters.AddWithValue("@namaProduk", product.NamaProduk);
                        cmd.Parameters.AddWithValue("@harga", product.Harga);
                        cmd.Parameters.AddWithValue("@stok", product.Stok);
                        cmd.Parameters.AddWithValue("@jenisProduk", product.JenisProduk);
                        cmd.Parameters.AddWithValue("@kriteriaProduk", product.KriteriaProduk);
                        cmd.Parameters.AddWithValue("@userId", AppSession.CurrentUser.UserId);

                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Create Product Error: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Product> GetByUserId(int userId)
        {
            List<Product> products = new List<Product>();

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"SELECT produk_id, nama_produk, harga, stok, jenis_produk, kriteria_produk, user_id
                    FROM products WHERE user_id = @userId";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Product product = new Product
                                {
                                    ProductId = reader.GetInt32(0),
                                    NamaProduk = reader.GetString(1),
                                    Harga = reader.GetInt32(2),
                                    Stok = reader.GetInt32(3),
                                    JenisProduk = reader.GetString(4),
                                    KriteriaProduk = reader.GetString(5),
                                    UserId = reader.GetInt32(6),
                                };
                                products.Add(product);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Get Product By UserID Error: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return products;
        }

        public List<Product> GetAllProduct()
        {
            List<Product> products = new List<Product>();

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"SELECT produk_id, nama_produk, harga, stok, jenis_produk, kriteria_produk, user_id, foto_produk
                    FROM products";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Product product = new Product
                                {
                                    ProductId = reader.GetInt32(0),
                                    NamaProduk = reader.GetString(1),
                                    Harga = reader.GetInt32(2),
                                    Stok = reader.GetInt32(3),
                                    JenisProduk = reader.GetString(4),
                                    KriteriaProduk = reader.GetString(5),
                                    UserId = reader.GetInt32(6),
                                    FotoProduk = (byte[])reader["foto_produk"]
                                };
                                products.Add(product);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Get Product By UserID Error: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return products;
        }
    }
}
