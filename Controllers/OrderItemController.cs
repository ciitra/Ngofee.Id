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
    public class OrderItemController
    {
        private DbContext _db;

        public OrderItemController()
        {
            _db = new DbContext();
        }

        public void InsertOrderItem(OrderItem item)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_db.connStr))
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO order_items (order_id, produk_id, quantity, subtotal, total_income)
                        VALUES (@order, @produk, @qty, @sub, @tot)
                    ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@order", item.OrderId);
                        cmd.Parameters.AddWithValue("@produk", item.ProdukId);
                        cmd.Parameters.AddWithValue("@qty", item.Quantity);
                        cmd.Parameters.AddWithValue("@sub", item.Subtotal);
                        cmd.Parameters.AddWithValue("@tot", item.TotalIncome);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("OrderItem Error: " + ex.Message);
            }
        }
    }
}