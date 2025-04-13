using Dynamo_Ecommerce.Models.Product;

namespace Dynamo_Ecommerce.Models.Shopping
{
    public class OrderItems
    {
        public int Id { get; set; }
        public Order Order {  get; set; }
        public int Quantity { get; set; }
        
        public ProductVariant productVariant { get; set; }  
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
