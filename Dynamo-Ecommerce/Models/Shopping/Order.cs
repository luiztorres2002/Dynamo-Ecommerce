using Dynamo_Ecommerce.Models.UserModel;

namespace Dynamo_Ecommerce.Models.Shopping
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; } 
        public decimal Total { get; set; }  
        public string Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public PaymentDetails? PaymentDetails { get; set; } 
        public ICollection<OrderItems> OrderItems { get; set; } = new List<OrderItems>();   
    }
}
