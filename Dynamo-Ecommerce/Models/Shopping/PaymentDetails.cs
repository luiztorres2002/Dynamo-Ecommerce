namespace Dynamo_Ecommerce.Models.Shopping
{
    public class PaymentDetails
    {
        public int Id { get; set; }
        public Order? order { get; set; }
        public decimal Amount { get; set; }
        public string Provider { get; set; }
        public string Status { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; } 
    }
}
