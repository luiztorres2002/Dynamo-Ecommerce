using Dynamo_Ecommerce.Models.UserModel;

namespace Dynamo_Ecommerce.Models.Shopping
{
    internal class ShoppingSession
    {
        public int Id { get; set; } 
        public User User { get; set; }
        public decimal Total {  get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();


    }
}
