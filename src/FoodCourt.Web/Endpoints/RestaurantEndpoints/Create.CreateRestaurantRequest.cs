using FoodCourt.SharedKernel;

namespace FoodCourt.Web.Endpoints.RestaurantEndpoints;

public class CreateRestaurantRequest
{
  public const string Route = "/Restaurants";

  public LocalName Name { get; set; } = new();
}
