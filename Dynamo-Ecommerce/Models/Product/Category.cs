﻿namespace Dynamo_Ecommerce.Models.Product
{
    internal class Category
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public DateTime? CreatedAt {get; set;}
        public DateTime? UpdatedAt {get; set;} 

        public ICollection<Product> Products {get; set;} = new List<Product>(); 

    }
}
