using APBD_Kol1.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_Kol1.EfConfigurations;

public class SubscriptionEfConfiguration : IEntityTypeConfiguration<Subscription>
{
    public void Configure(EntityTypeBuilder<Subscription> builder)
    {
        builder.Property(s => s.IdSubscription).ValueGeneratedOnAdd();
        builder.HasKey(s => s.IdSubscription);

        builder.Property(s => s.Name).IsRequired().HasMaxLength(100);
        builder.Property(s => s.RenewalPeriod).IsRequired();
        builder.Property(s => s.EndTime).IsRequired();
        builder.Property(s => s.Price).IsRequired().HasColumnType("money");

        builder.HasMany(s => s.PaymentsNavigation)
            .WithOne(p => p.SubscriptionNavigation)
            .HasForeignKey(p => p.IdSubscription);

        builder.HasMany(s => s.SalesNavigation)
            .WithOne(sale => sale.SubscriptionNavigation)
            .HasForeignKey(sale => sale.IdSubscription);

        builder.HasMany(s => s.DiscountsNavigation)
            .WithOne(d => d.SubscriptionNavigation)
            .HasForeignKey(d => d.IdSubscription);
    }
}