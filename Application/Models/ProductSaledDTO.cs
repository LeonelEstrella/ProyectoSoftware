﻿namespace Application.Models
{
    public class ProductSaledDTO
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int? Discount { get; set; }
        public int Category { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }
    }
}
