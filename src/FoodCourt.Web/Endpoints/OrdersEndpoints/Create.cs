using Ardalis.GuardClauses;
using FastEndpoints;
using FoodCourt.SharedKernel.Interfaces;

namespace FoodCourt.Web.Endpoints.OrdersEndpoints;

using Order = Core.OrderAggregate.Order;
public class Create : Endpoint<CreateOrderRequest, CreateOrderResponse>
{
  private readonly IRepository<Order> _repository;

  public Create(IRepository<Order> repository)
  {
    _repository = repository;
  }

  public override void Configure()
  {
    Post(CreateOrderRequest.Route);
    AllowAnonymous();
    Options(o => o.WithGroupName("OrdersEndpoints"));
  }

  public override async Task HandleAsync(CreateOrderRequest req, CancellationToken ct)
  {
    Guard.Against.NegativeOrZero(req.OwnerId);
    Guard.Against.NegativeOrZero(req.RestaurantId);
    var order = new Order(req.RestaurantId, req.OwnerId);
    var createdItem = await _repository.AddAsync(order, ct);
    var response = new CreateOrderResponse
    (
      Id: createdItem.Id,
      CreatedAt: createdItem.Created
    );
    await SendAsync(response, cancellation: ct);
  }
}
