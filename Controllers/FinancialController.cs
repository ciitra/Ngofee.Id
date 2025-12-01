using Ngofee.Id.Database;
using Ngofee.Id.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngofee.Id.Controllers
{
    public class FinancialController
    {
        private DbContext _db;

        public FinancialController()
        {
            _db = new DbContext();
        }

        public IncomeSummary GetIncomeSummary()
        {
            IncomeSummary summary = new IncomeSummary();

            using (var conn = new NpgsqlConnection(_db.connStr))
            {
                conn.Open();

                string q1 = @"SELECT SUM(oi.subtotal) 
                              FROM order_items oi
                              JOIN orders o ON oi.order_id = o.order_id
                              WHERE DATE(o.order_date) = CURRENT_DATE;";

                using (var cmd = new NpgsqlCommand(q1, conn))
                {
                    object result = cmd.ExecuteScalar();
                    summary.PendapatanHarian = result == DBNull.Value ? 0 : Convert.ToDecimal(result);
                }

                summary.TanggalHariIni = DateTime.Now.ToString("dd MMM yyyy");

                string q2 = @"SELECT SUM(oi.subtotal)
                              FROM order_items oi
                              JOIN orders o ON oi.order_id = o.order_id
                              WHERE DATE_PART('month', o.order_date) = DATE_PART('month', CURRENT_DATE)
                                AND DATE_PART('year', o.order_date) = DATE_PART('year', CURRENT_DATE);";

                using (var cmd = new NpgsqlCommand(q2, conn))
                {
                    object result = cmd.ExecuteScalar();
                    summary.PendapatanBulanan = result == DBNull.Value ? 0 : Convert.ToDecimal(result);
                }

                summary.BulanIni = DateTime.Now.ToString("MMMM yyyy");
            }

            return summary;
        }

        public List<AdminFinancialReport> GetFinancialHistory()
        {
            var list = new List<AdminFinancialReport>();

            try
            {
                using (var conn = new NpgsqlConnection(_db.connStr))
                {
                    conn.Open();

                    // 1) Subquery: hitung total & list produk per order
                    string q = @"
                SELECT 
                    agg.order_id,
                    agg.order_date,
                    agg.status,
                    agg.produk_list,
                    agg.total_income,
                    p.foto_produk
                FROM (
                    SELECT
                        o.order_id,
                        o.order_date,
                        o.status,
                        STRING_AGG(p.nama_produk, ', ') AS produk_list,
                        SUM(oi.subtotal) AS total_income,
                        MIN(oi.produk_id) AS first_produk_id     -- aman, integer
                    FROM order_items oi
                    JOIN orders o ON oi.order_id = o.order_id
                    JOIN products p ON oi.produk_id = p.produk_id
                    GROUP BY o.order_id, o.order_date, o.status
                ) agg
                JOIN products p ON p.produk_id = agg.first_produk_id
                ORDER BY agg.order_date DESC;";

                    using (var cmd = new NpgsqlCommand(q, conn))
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            list.Add(new AdminFinancialReport
                            {
                                // Kalau di model kamu ada OrderId, boleh diisi:
                                // OrderId = rd.GetInt32(0),
                                Tanggal = rd.GetDateTime(1),
                                Status = rd.GetString(2),
                                ProdukList = rd.GetString(3),
                                TotalIncome = rd.GetDecimal(4),
                                FotoProduk = rd["foto_produk"] as byte[]
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load riwayat keuangan: " + ex.Message);
            }

            return list;
        }
    }
}
