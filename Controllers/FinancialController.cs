using Ngofee.Id.Database;
using Ngofee.Id.Iinterfaces;
using Ngofee.Id.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ngofee.Id.Controllers
{
    public class FinancialController : BaseController, IFinancial
    {
        public FinancialController() : base()
        {
        }

        public IncomeSummary GetIncomeSummary()
        {
            IncomeSummary summary = new IncomeSummary();

            try
            {
                using (var conn = CreateConnection())
                {
                    conn.Open();

                    string dailyQuery = @"
                        SELECT SUM(oi.subtotal)
                        FROM order_items oi
                        JOIN orders o ON oi.order_id = o.order_id
                        WHERE DATE(o.order_date) = CURRENT_DATE";

                    summary.PendapatanHarian = ExecuteScalarDecimal(conn, dailyQuery);
                    summary.TanggalHariIni = DateTime.Now.ToString("dd MMM yyyy");

                    string monthlyQuery = @"
                        SELECT SUM(oi.subtotal)
                        FROM order_items oi
                        JOIN orders o ON oi.order_id = o.order_id
                        WHERE DATE_PART('month', o.order_date) = DATE_PART('month', CURRENT_DATE)
                          AND DATE_PART('year', o.order_date) = DATE_PART('year', CURRENT_DATE)";

                    summary.PendapatanBulanan = ExecuteScalarDecimal(conn, monthlyQuery);
                    summary.BulanIni = DateTime.Now.ToString("MMMM yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Summary Error: " + ex.Message);
            }

            return summary;
        }

        public List<AdminFinancialReport> GetFinancialHistory()
        {
            var list = new List<AdminFinancialReport>();

            try
            {
                using (var conn = CreateConnection())
                {
                    conn.Open();

                    string query = @"
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
                                MIN(oi.produk_id) AS first_produk_id
                            FROM order_items oi
                            JOIN orders o ON oi.order_id = o.order_id
                            JOIN products p ON oi.produk_id = p.produk_id
                            GROUP BY o.order_id, o.order_date, o.status
                        ) agg
                        JOIN products p ON p.produk_id = agg.first_produk_id
                        ORDER BY agg.order_date DESC";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            list.Add(MapFinancialReport(rd));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("History Error: " + ex.Message);
            }

            return list;
        }

        private decimal ExecuteScalarDecimal(NpgsqlConnection conn, string query)
        {
            using (var cmd = new NpgsqlCommand(query, conn))
            {
                object result = cmd.ExecuteScalar();
                return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
            }
        }

        private AdminFinancialReport MapFinancialReport(NpgsqlDataReader rd)
        {
            return new AdminFinancialReport
            {
                Tanggal = rd.GetDateTime(1),
                Status = rd.GetString(2),
                ProdukList = rd.GetString(3),
                TotalIncome = rd.GetDecimal(4),
                FotoProduk = rd["foto_produk"] as byte[]
            };
        }
    }
}
