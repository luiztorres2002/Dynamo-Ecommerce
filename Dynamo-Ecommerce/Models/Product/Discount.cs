﻿namespace Dynamo_Ecommerce.Models.Product
{
    public class Discount
    {
        public int Id {get; set;}
        public string Description {get; set;} 
        public decimal DiscountPercentage {get; set;}
        public bool Active {get; set;}
    }
}
