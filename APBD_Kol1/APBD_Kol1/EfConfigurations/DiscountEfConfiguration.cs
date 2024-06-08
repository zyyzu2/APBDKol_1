using APBD_Kol1.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_Kol1.EfConfigurations;

public class DiscountEfConfiguration : IEntityTypeConfiguration<Discount>
{
    public void Configure(EntityTypeBuilder<Discount> builder)
    {
        builder.Property(d => d.IdDiscount).ValueGeneratedOnAdd();
        builder.HasKey(d => d.IdDiscount);

        builder.Property(d => d.Value).IsRequired();
        builder.Property(d => d.DateFrom).IsRequired();
        builder.Property(d => d.DateTo).IsRequired();
    }
}