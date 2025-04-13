namespace Dynamo_Ecommerce.Models.Product
{
    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public string SKU { get; set; }
        public Category Category { get; set; }
        public DateTime? CreatedAt { get; set; }    
        public DateTime? UpdatedAt { get; set; }
        
        public ICollection<Image> images { get; set; } = new List<Image>(); 

    }
}
