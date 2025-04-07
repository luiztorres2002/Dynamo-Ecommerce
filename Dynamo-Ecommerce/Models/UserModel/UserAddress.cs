

namespace Dynamo_Ecommerce.Models.UserModel
{
    internal class UserAddress
    {
        public int Id { get; set; }
        public User user { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public Province Province { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }
}
