using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngofee.Id.Models
{
    public class OrderHistory
    {
        public int OrderId { get; set; }
        public DateTime Tanggal { get; set; }
        public string Status { get; set; } = "";
        public decimal TotalHarga { get; set; }

        public List<OrderHistoryItem> Items { get; set; } = new List<OrderHistoryItem>();
    }
}
