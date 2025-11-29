using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngofee.Id.Models
{
    public class AdminOrder
    {
        public int OrderId { get; set; }
        public string Pembeli { get; set; }
        public string NamaPenerima { get; set; }
        public string AlamatTujuan { get; set; }
        public string MetodePembayaran { get; set; }
        public string MetodePengiriman { get; set; }
        public string Status { get; set; }
        public DateTime Tanggal { get; set; }

        public List<AdminOrderItem> Items { get; set; }
    }

    public class AdminOrderItem
    {
        public string NamaProduk { get; set; }
        public decimal Subtotal { get; set; }
        public byte[] FotoProduk { get; set; }
        public int Quantity { get; set; }
    }
}
