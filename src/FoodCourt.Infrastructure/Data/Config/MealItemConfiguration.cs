using FoodCourt.Core.RestaurantAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodCourt.Infrastructure.Data.Config;
public class MealItemConfiguration : IEntityTypeConfiguration<MealItem>
{
  public void Configure(EntityTypeBuilder<MealItem> builder)
  {
    builder.OwnsOne(x => x.LocalizedName, b => { b.ToJson(); });
  }
}
