using Dynamo_Ecommerce.Models;

namespace Dynamo_Ecommerce.Models.UserModel
{
    internal class UserPayment
    {
        public int Id { get; set; }
        public User user { get; set; }
        public PaymentType paymentType { get; set; }
        public string Provider { get; set; }


    }

}
