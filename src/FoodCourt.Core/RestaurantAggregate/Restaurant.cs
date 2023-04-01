using FoodCourt.SharedKernel;
using FoodCourt.SharedKernel.Interfaces;

namespace FoodCourt.Core.RestaurantAggregate;
public class Restaurant : EntityBase , IAggregateRoot
{
  public string Name { get; set; } = string.Empty;


  private List<MealItem> _mealItems = new ();
  public IEnumerable<MealItem> MealItems => _mealItems.AsReadOnly();



}
