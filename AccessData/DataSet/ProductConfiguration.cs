﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccessData.DataSet
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 },
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31 }
                );
        }
    }
}
