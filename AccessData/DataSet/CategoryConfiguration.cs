using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccessData.DataSet
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { CategoryId = 1, Name = "Electrodomésticos" },
                new Category { CategoryId = 2, Name = "Tecnología y Electrónica" },
                new Category { CategoryId = 3, Name = "Electrodomésticos" },
                new Category { CategoryId = 4, Name = "Tecnología y Electrónica" },
                new Category { CategoryId = 5, Name = "Electrodomésticos" },
                new Category { CategoryId = 6, Name = "Tecnología y Electrónica" },
                new Category { CategoryId = 7, Name = "Electrodomésticos" },
                new Category { CategoryId = 8, Name = "Tecnología y Electrónica" },
                new Category { CategoryId = 9, Name = "Electrodomésticos" },
                new Category { CategoryId = 10, Name = "Tecnología y Electrónica" }
                );           
        }
    }
}
