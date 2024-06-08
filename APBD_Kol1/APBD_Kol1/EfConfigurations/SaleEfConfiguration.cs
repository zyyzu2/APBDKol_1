using APBD_Kol1.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_Kol1.EfConfigurations;

public class SaleEfConfiguration : IEntityTypeConfiguration<Sale>
{
    public void Configure(EntityTypeBuilder<Sale> builder)
    {
        builder.Property(s => s.IdSale).ValueGeneratedOnAdd();
        builder.HasKey(s => s.IdSale);

        builder.Property(s => s.CreatedAt).IsRequired();
    }
}