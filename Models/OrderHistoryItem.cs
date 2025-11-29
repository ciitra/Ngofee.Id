using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngofee.Id.Models
{
    public class OrderHistoryItem
    {
        public int ProdukId { get; set; }
        public string NamaProduk { get; set; } = "";
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }
        public byte[]? FotoProduk { get; set; }
    }
}
