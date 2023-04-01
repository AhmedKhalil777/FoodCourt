using FoodCourt.SharedKernel;

namespace FoodCourt.Core.OrderAggregate;
public class OrderRequest : EntityBase
{
  public int? RequesterId { get; set; }
  private List<OrderItem> _items = new();
  public IEnumerable<OrderItem> Items => _items.AsReadOnly();

  public double Price { get; set; }
}
