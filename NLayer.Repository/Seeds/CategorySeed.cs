using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    //Seed Data her projede ihtiyaç olan bir konu değildir.
    //Özellikle multi-tenant uygulamalarda ihtiyaç olur.
    //Müşteriye ait bir db oluşturulurken aynı zamanda default rol bilgilerinin veya default kullanıcıların bilgilerinin db'ye yazılması istenebilir.
    //Özetle her zaman kullanılmaz, ihtiyaç olduğunda.
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, Name = "Kalemler" },
                new Category { Id = 2, Name = "Kitaplar" },
                new Category { Id = 3, Name = "Defterler" });
        }
    }
}
