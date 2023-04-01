namespace FoodCourt.Web.Endpoints.OrdersEndpoints;

public class CreateOrderRequest
{
  public const string Route = "/Orders";

  public int OwnerId { get; set; }
  public int RestaurantId { get; set; }
}
