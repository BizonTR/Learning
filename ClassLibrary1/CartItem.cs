using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public Product Product { get; set; }
        public uint Quantity { get; set; } //pozitif sayı olması için
    }
}
