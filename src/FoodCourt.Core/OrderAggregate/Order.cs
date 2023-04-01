using FoodCourt.Core.ProjectAggregate;
using FoodCourt.SharedKernel;
using FoodCourt.SharedKernel.Interfaces;

namespace FoodCourt.Core.OrderAggregate;
public class Order : EntityBase, IAggregateRoot
{
  public Order(int restaurantId, int ownerId)
  {
    RestaurantId = restaurantId; 
    OwnerId = ownerId;
  }
  public int RestaurantId { get; private set; }

  public int OwnerId { get; set; }

  private List<OrderRequest> _requests = new ();
  public IEnumerable<OrderRequest> Requests => _requests.AsReadOnly();
  public double TotalPrice { get; set; }
}
