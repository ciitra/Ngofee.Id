using Ngofee.Id.Database;
using Ngofee.Id.Helpers;
using Ngofee.Id.Iinterfaces;
using Ngofee.Id.Models;
using Npgsql;

namespace Ngofee.Id.Controllers
{
    public class ProductController : BaseController, IProduct
    {
        public ProductController() : base()
        {
        }

        public void CreateProduct(Product product)
        {
            if (!ValidateProduct(product))
                return;

            try
            {
                using (var conn = CreateConnection())
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO products
                        (foto_produk, nama_produk, harga, stok, jenis_produk, kriteria_produk, user_id, created_at)
                        VALUES
                        (@foto, @nama, @harga, @stok, @jenis, @kriteria, @userId, NOW())";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@foto", product.FotoProduk);
                        cmd.Parameters.AddWithValue("@nama", product.NamaProduk);
                        cmd.Parameters.AddWithValue("@harga", product.Harga);
                        cmd.Parameters.AddWithValue("@stok", product.Stok);
                        cmd.Parameters.AddWithValue("@jenis", product.JenisProduk);
                        cmd.Parameters.AddWithValue("@kriteria", product.KriteriaProduk);
                        cmd.Parameters.AddWithValue("@userId", AppSession.CurrentUser.UserId);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Create Product Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 
        public List<Product> GetByUserId(int userId)
        {
            List<Product> products = new List<Product>();

            try
            {
                using (var conn = CreateConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT produk_id, nama_produk, harga, stok, jenis_produk, kriteria_produk, user_id
                        FROM products
                        WHERE user_id = @userId";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);

                        using (var rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                products.Add(MapProduct(rd, includeImage: false));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Get Product Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return products;
        }


        public List<Product> GetAllProduct()
        {
            List<Product> products = new List<Product>();

            try
            {
                using (var conn = CreateConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT produk_id, nama_produk, harga, stok, jenis_produk,
                               kriteria_produk, user_id, foto_produk
                        FROM products";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                products.Add(MapProduct(rd, includeImage: true));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Get All Product Error: " + ex.Message);
            }

            return products;
        }


        public void DeleteProduct(int productId)
        {
            try
            {
                using (var conn = CreateConnection())
                {
                    conn.Open();

                    string query = @"DELETE FROM products WHERE produk_id = @id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", productId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Product Error: " + ex.Message);
            }
        }


        private bool ValidateProduct(Product p)
        {
            if (AppSession.CurrentUser == null)
            {
                MessageBox.Show("User tidak terautentikasi.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(p.NamaProduk) ||
                string.IsNullOrWhiteSpace(p.JenisProduk) ||
                string.IsNullOrWhiteSpace(p.KriteriaProduk))
            {
                MessageBox.Show("Data produk belum lengkap!");
                return false;
            }

            if (p.Harga <= 0 || p.Stok < 0)
            {
                MessageBox.Show("Harga atau stok tidak valid.");
                return false;
            }

            return true;
        }

        private Product MapProduct(NpgsqlDataReader rd, bool includeImage)
        {
            var product = new Product
            {
                ProductId = rd.GetInt32(0),
                NamaProduk = rd.GetString(1),
                Harga = rd.GetInt32(2),
                Stok = rd.GetInt32(3),
                JenisProduk = rd.GetString(4),
                KriteriaProduk = rd.GetString(5),
                UserId = rd.GetInt32(6),
            };

            if (includeImage)
            {
                product.FotoProduk = rd["foto_produk"] as byte[];
            }

            return product;
        }
    }
}
