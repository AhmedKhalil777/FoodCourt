using FoodCourt.Core.RestaurantAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodCourt.Infrastructure.Data.Config;
public class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
{
  public void Configure(EntityTypeBuilder<Restaurant> builder)
  {
    throw new NotImplementedException();
  }
}
