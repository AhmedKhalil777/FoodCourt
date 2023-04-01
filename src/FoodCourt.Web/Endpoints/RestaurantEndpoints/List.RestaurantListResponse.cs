namespace FoodCourt.Web.Endpoints.RestaurantEndpoints;

public class RestaurantListResponse
{
  public IEnumerable<RestaurantRecord> Restaurants { get; set; } = Enumerable.Empty<RestaurantRecord>();
}
