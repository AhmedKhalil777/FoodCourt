using FoodCourt.Core.RestaurantAggregate;
using FoodCourt.SharedKernel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodCourt.Infrastructure.Data.Config;
public class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
{
  public void Configure(EntityTypeBuilder<Restaurant> builder)
  {
    builder.OwnsOne(r => r.LocalizedName, b =>
    {
      b.ToJson();
      b.OwnsMany(x => x.Locals,  k => { 
        k.Property(p => p.Lang)
        .HasConversion(
            p => p.Value,
            p => Language.FromValue(p));
      });
    });
  }
}
