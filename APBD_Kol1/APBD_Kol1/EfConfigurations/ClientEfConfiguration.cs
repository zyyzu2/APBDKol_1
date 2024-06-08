using APBD_Kol1.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_Kol1.EfConfigurations;

public class ClientEfConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.HasKey(c => c.IdClient);
        builder.Property(c => c.IdClient).ValueGeneratedOnAdd();

        builder.Property(c => c.FirstName).IsRequired().HasMaxLength(100);
        builder.Property(c => c.LastName).IsRequired().HasMaxLength(100);
        builder.Property(c => c.Email).IsRequired().HasMaxLength(100);
        builder.Property(c => c.Phone).HasMaxLength(100);

        builder.HasMany(c => c.SalesNavigation)
            .WithOne(s => s.ClientNavigation)
            .HasForeignKey(s => s.IdClient);

        builder.HasMany(c => c.PaymentsNavigation)
            .WithOne(p => p.ClientNavigation)
            .HasForeignKey(p => p.IdClient);
    }
}