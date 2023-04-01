using FoodCourt.SharedKernel;

namespace FoodCourt.Core.RestaurantAggregate;
public class MealItem : EntityBase
{
  public int RestaurantId  { get; private set; }

  public LocalName LocalizedName { get; set; } = new();
  public string ImageUrl { get; set; } = string.Empty;
  public double Price { get; set; }
}
