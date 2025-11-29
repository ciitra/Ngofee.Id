using Ngofee.Id.Database;
using Ngofee.Id.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngofee.Id.Controllers
{
    public class OrderController
    {
        private DbContext _db;

        public OrderController()
        {
            _db = new DbContext();
        }
        public int CreateOrder(Order order)
        {
            int newOrderId = 0;

            try
            {
                using (var conn = new NpgsqlConnection(_db.connStr))
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO orders
                        (user_id, nama_penerima, alamat_tujuan, metode_pembayaran, metode_pengiriman, bukti_pembayaran, status)
                        VALUES (@uid, @nama, @alamat, @metodeBayar, @metodeKirim, @bukti, 'pending')
                        RETURNING order_id;
                    ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", order.UserId);
                        cmd.Parameters.AddWithValue("@nama", order.NamaPenerima);
                        cmd.Parameters.AddWithValue("@alamat", order.AlamatTujuan);
                        cmd.Parameters.AddWithValue("@metodeBayar", order.MetodePembayaran);
                        cmd.Parameters.AddWithValue("@metodeKirim", order.MetodePengiriman);
                        cmd.Parameters.AddWithValue("@bukti", order.BuktiPembayaran ?? (object)DBNull.Value);

                        newOrderId = (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Order Error: " + ex.Message);
            }

            return newOrderId;
        }

        public void UpdateStatus(int orderId, string status)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_db.connStr))
                {
                    conn.Open();
                    string q = "UPDATE orders SET status = @s WHERE order_id = @id";

                    using (var cmd = new NpgsqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@s", status);
                        cmd.Parameters.AddWithValue("@id", orderId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update status gagal: " + ex.Message);
            }
        }


        public List<AdminOrder> GetAllOrdersForAdmin()
        {
            var list = new List<AdminOrder>();

            try
            {
                using (var conn = new NpgsqlConnection(_db.connStr))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    o.order_id,
                    u.username AS pembeli,
                    o.status,
                    o.order_date,
                    o.nama_penerima,
                    o.alamat_tujuan,
                    o.metode_pembayaran,
                    o.metode_pengiriman,
                    p.nama_produk,
                    oi.subtotal,
                    p.foto_produk
                FROM orders o
                JOIN users u ON o.user_id = u.user_id
                JOIN order_items oi ON o.order_id = oi.order_id
                JOIN products p ON oi.produk_id = p.produk_id
                ORDER BY o.order_date DESC;
            ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                int orderId = rd.GetInt32(0);

                                var existing = list.FirstOrDefault(x => x.OrderId == orderId);
                                if (existing == null)
                                {
                                    existing = new AdminOrder
                                    {
                                        OrderId = orderId,
                                        Pembeli = rd.GetString(1),
                                        Status = rd.GetString(2),
                                        Tanggal = rd.GetDateTime(3),
                                        Items = new List<AdminOrderItem>()
                                    };

                                    existing.NamaPenerima = rd.GetString(4);
                                    existing.AlamatTujuan = rd.GetString(5);
                                    existing.MetodePembayaran = rd.GetString(6);
                                    existing.MetodePengiriman = rd.GetString(7);
                                    list.Add(existing);
                                }

                                existing.Items.Add(new AdminOrderItem
                                {
                                    NamaProduk = rd.GetString(8),         
                                    Subtotal = rd.GetDecimal(9),          
                                    FotoProduk = rd["foto_produk"] as byte[]
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load transaksi admin salah: " + ex.Message);
            }

            return list;
        }

        public List<OrderHistory> GetHistoryByUser(int userId)
        {
            List<OrderHistory> orders = new List<OrderHistory>();

            try
            {
                using (var conn = new NpgsqlConnection(_db.connStr))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    o.order_id,
                    o.order_date,
                    o.status,
                    oi.produk_id,
                    oi.quantity,
                    oi.subtotal,
                    p.nama_produk,
                    p.foto_produk
                FROM order_items oi
                JOIN orders o ON oi.order_id = o.order_id
                JOIN products p ON oi.produk_id = p.produk_id
                WHERE o.user_id = @uid
                ORDER BY o.order_date DESC;";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", userId);

                        using (var rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                int orderId = rd.GetInt32(0);

                                // cek apakah order sudah ada
                                var existing = orders.FirstOrDefault(o => o.OrderId == orderId);

                                if (existing == null)
                                {
                                    existing = new OrderHistory
                                    {
                                        OrderId = orderId,
                                        Tanggal = rd.GetDateTime(1),
                                        Status = rd.GetString(2),
                                        TotalHarga = 0,
                                        Items = new List<OrderHistoryItem>()
                                    };

                                    orders.Add(existing);
                                }

                                // Tambahkan item ke dalam order
                                existing.Items.Add(new OrderHistoryItem
                                {
                                    ProdukId = rd.GetInt32(3),
                                    Quantity = rd.GetInt32(4),
                                    Subtotal = rd.GetDecimal(5),
                                    NamaProduk = rd.GetString(6),
                                    FotoProduk = rd["foto_produk"] as byte[]
                                });

                                existing.TotalHarga += rd.GetDecimal(5);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load history: " + ex.Message);
            }

            return orders;
        }

    }
}
