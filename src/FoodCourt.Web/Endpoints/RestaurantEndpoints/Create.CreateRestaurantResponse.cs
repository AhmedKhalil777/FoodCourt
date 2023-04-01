using FoodCourt.SharedKernel;

namespace FoodCourt.Web.Endpoints.RestaurantEndpoints;

public class CreateRestaurantResponse
{
  public CreateRestaurantResponse(int id, LocalName name)
  {
    Id = id;
    Name = name;
  }
  public int Id { get; set; }
  public LocalName Name { get; set; }
}
