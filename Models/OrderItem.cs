using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngofee.Id.Models
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public int ProdukId { get; set; }
        public string NamaProduk { get; set; }
        public int Harga { get; set; }
        public int Quantity { get; set; }
        public int Subtotal => Harga * Quantity;
        public int TotalIncome => Harga * Quantity;
        public byte[] FotoProduk { get; set; }
    }
}
