﻿namespace Domain.Entities
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        public required string Name { get; set; }
    }
}