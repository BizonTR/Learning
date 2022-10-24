using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cart
    {
        private List<CartItem> CartItems { get; set; }
        public Cart()
        {
            CartItems=new List<CartItem>();
        }
        public void AddItem(CartItem cartItem)
        {
            CartItems.Add(cartItem);
        }

        public void RemoveItem(int id)
        {
            var cartItem = CartItems.Where(ci => ci.CartItemId == id).FirstOrDefault();  
        }

        public void ShowCart()
        {
            decimal totalCount = 0;
            foreach (var item in CartItems)
            {
                totalCount += item.Product.Price * item.Quantity;
                Console.WriteLine($"{item.Product.ProductName} - {item.Quantity} - {item.Product.Price} {item.Quantity*item.Product.Price}");
            }
            Console.WriteLine($"Total Cart Price: {totalCount}");
        }
    }
}
