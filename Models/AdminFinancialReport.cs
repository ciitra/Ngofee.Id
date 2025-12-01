using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngofee.Id.Models
{
    public class AdminFinancialReport
    {
        public DateTime Tanggal { get; set; }
        public string Status { get; set; }
        public string ProdukList { get; set; }
        public decimal TotalIncome { get; set; }
        public byte[] FotoProduk { get; set; }
    }

    public class IncomeSummary
    {
        public decimal PendapatanHarian { get; set; }
        public string TanggalHariIni { get; set; }

        public decimal PendapatanBulanan { get; set; }
        public string BulanIni { get; set; }
    }
}
