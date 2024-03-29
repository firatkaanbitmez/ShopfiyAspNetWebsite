//Data/CartViewModel.cs
using System.ComponentModel.DataAnnotations;

namespace ShopAppProject.Data
{
    public class CartViewModel
    {
        public List<CartItem>? CartItems { get; set; }
        public decimal TotalAmount { get; set; }
        public required Dictionary<string, decimal> TotalAmounts { get; set; }
        public List<UserProductList>? UserProductList { get; set; }
        public bool HasInactiveProducts { get; set; }

    }
}
