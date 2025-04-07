using Dynamo_Ecommerce.Models.Product;

namespace Dynamo_Ecommerce.Models.Shopping
{
    internal class CartItem
    {
        public int Id { get; set; }
        public ShoppingSession ShoppinSession { get; set; } 
        
        public ProductVariant ProductVariant { get; set; }

        public int Quantity {  get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }
}
