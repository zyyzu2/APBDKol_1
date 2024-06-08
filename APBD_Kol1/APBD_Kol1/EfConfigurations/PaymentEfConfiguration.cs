using APBD_Kol1.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_Kol1.EfConfigurations;

public class PaymentEfConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.Property(p => p.IdPayment).ValueGeneratedOnAdd();
        builder.HasKey(p => p.IdPayment);

        builder.Property(p => p.Date).IsRequired();
    }
}