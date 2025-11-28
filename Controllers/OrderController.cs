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

                    string query = "UPDATE orders SET status = @status WHERE order_id = @id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@id", orderId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Status Error: " + ex.Message);
            }
        }
    }
}
