namespace Dynamo_Ecommerce.Models.Product
{
    public class ProductVariant
    {
        public int Id { get; set; } 
        public Product? Product { get; set; }
        public Size? size  { get; set; } 
        public Color? color { get; set; }        
        public decimal price { get; set; }  
        public Discount? discount { get; set; }
        public int Stock {  get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }
}
