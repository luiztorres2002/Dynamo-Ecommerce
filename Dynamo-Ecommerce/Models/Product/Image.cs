namespace Dynamo_Ecommerce.Models.Product
{
    internal class Image
    {
        public int Id { get; set; } 
        public Product Product { get; set; }
        public Color Color { get; set; }
        public string ImageUrl { get; set; }
        public DateTime? CreatedAt { get; set; }


    }
}
