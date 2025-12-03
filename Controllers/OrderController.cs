using Ngofee.Id.Database;
using Ngofee.Id.Iinterfaces;
using Ngofee.Id.Models;
using Npgsql;

namespace Ngofee.Id.Controllers
{
    public class OrderController : BaseController, IOrder
    {
        public OrderController() : base()
        {
        }

        public int CreateOrder(Order order)
        {
            try
            {
                using (var conn = CreateConnection())
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO orders
                        (user_id, nama_penerima, alamat_tujuan, metode_pembayaran, metode_pengiriman, bukti_pembayaran, status)
                        VALUES (@uid, @nama, @alamat, @metodeBayar, @metodeKirim, @bukti, 'pending')
                        RETURNING order_id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", order.UserId);
                        cmd.Parameters.AddWithValue("@nama", order.NamaPenerima);
                        cmd.Parameters.AddWithValue("@alamat", order.AlamatTujuan);
                        cmd.Parameters.AddWithValue("@metodeBayar", order.MetodePembayaran);
                        cmd.Parameters.AddWithValue("@metodeKirim", order.MetodePengiriman);
                        cmd.Parameters.AddWithValue("@bukti", order.BuktiPembayaran ?? (object)DBNull.Value);

                        return (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Order Error: " + ex.Message);
                return 0;
            }
        }

        public void InsertOrderItem(OrderItem item)
        {
            try
            {
                using (var conn = CreateConnection())
                {
                    conn.Open();

                    string query = @"
                INSERT INTO order_items (order_id, produk_id, quantity, subtotal, total_income)
                VALUES (@order, @produk, @qty, @sub, @total)";

                    using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@order", item.OrderId);
                        cmd.Parameters.AddWithValue("@produk", item.ProdukId);
                        cmd.Parameters.AddWithValue("@qty", item.Quantity);
                        cmd.Parameters.AddWithValue("@sub", item.Subtotal);
                        cmd.Parameters.AddWithValue("@total", item.TotalIncome);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert OrderItem Error: " + ex.Message);
            }
        }

        public void UpdateStatus(int orderId, string status)
        {
            try
            {
                using (var conn = CreateConnection())
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
                using (var conn = CreateConnection())
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
                        ORDER BY o.order_date DESC";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                int orderId = rd.GetInt32(0);

                                var existingOrder = list.FirstOrDefault(o => o.OrderId == orderId);

                                if (existingOrder == null)
                                {
                                    existingOrder = MapAdminOrder(rd);
                                    list.Add(existingOrder);
                                }

                                existingOrder.Items.Add(MapAdminOrderItem(rd));
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
            var orders = new List<OrderHistory>();

            try
            {
                using (var conn = CreateConnection())
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
                        ORDER BY o.order_date DESC";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", userId);

                        using (var rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                int orderId = rd.GetInt32(0);

                                var existingOrder = orders.FirstOrDefault(o => o.OrderId == orderId);

                                if (existingOrder == null)
                                {
                                    existingOrder = MapOrderHistory(rd);
                                    orders.Add(existingOrder);
                                }

                                existingOrder.Items.Add(MapOrderHistoryItem(rd));
                                existingOrder.TotalHarga += rd.GetDecimal(5);
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


        private AdminOrder MapAdminOrder(NpgsqlDataReader rd)
        {
            return new AdminOrder
            {
                OrderId = rd.GetInt32(0),
                Pembeli = rd.GetString(1),
                Status = rd.GetString(2),
                Tanggal = rd.GetDateTime(3),
                NamaPenerima = rd.GetString(4),
                AlamatTujuan = rd.GetString(5),
                MetodePembayaran = rd.GetString(6),
                MetodePengiriman = rd.GetString(7),
                Items = new List<AdminOrderItem>()
            };
        }

        private AdminOrderItem MapAdminOrderItem(NpgsqlDataReader rd)
        {
            return new AdminOrderItem
            {
                NamaProduk = rd.GetString(8),
                Subtotal = rd.GetDecimal(9),
                FotoProduk = rd["foto_produk"] as byte[]
            };
        }

        private OrderHistory MapOrderHistory(NpgsqlDataReader rd)
        {
            return new OrderHistory
            {
                OrderId = rd.GetInt32(0),
                Tanggal = rd.GetDateTime(1),
                Status = rd.GetString(2),
                TotalHarga = 0,
                Items = new List<OrderHistoryItem>()
            };
        }

        private OrderHistoryItem MapOrderHistoryItem(NpgsqlDataReader rd)
        {
            return new OrderHistoryItem
            {
                ProdukId = rd.GetInt32(3),
                Quantity = rd.GetInt32(4),
                Subtotal = rd.GetDecimal(5),
                NamaProduk = rd.GetString(6),
                FotoProduk = rd["foto_produk"] as byte[]
            };
        }
    }
}
