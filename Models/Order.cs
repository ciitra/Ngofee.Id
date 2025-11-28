using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngofee.Id.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public string NamaPenerima { get; set; }
        public string AlamatTujuan { get; set; }
        public string MetodePembayaran { get; set; }
        public string MetodePengiriman { get; set; }
        public byte[] BuktiPembayaran { get; set; }
        public string Status { get; set; }
        public static List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public static void Clear()
        {
            Items.Clear();
        }
    }
}