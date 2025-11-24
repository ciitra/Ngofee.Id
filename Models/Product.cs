using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngofee.Id.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string NamaProduk { get; set; }
        public int Harga { get; set; }
        public int Stok { get; set; }
        public string JenisProduk { get; set; }
        public string KriteriaProduk { get; set; }
        public byte[] FotoProduk { get; set; }
        public int UserId { get; set; }
    }
}
