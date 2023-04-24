using Ardalis.GuardClauses;
using FoodCourt.SharedKernel;
using FoodCourt.SharedKernel.Interfaces;

namespace FoodCourt.Core.RestaurantAggregate;
public class Restaurant : EntityBase , IAggregateRoot
{
  public LocalName LocalizedName { get; set; } = new();


  private List<MealItem> _mealItems = new ();
  public IEnumerable<MealItem> MealItems => _mealItems.AsReadOnly();


  public void AddMealItem(MealItem mealItem)
  {
    Guard.Against.Null(mealItem);
    _mealItems.Add(mealItem);
  }

}
