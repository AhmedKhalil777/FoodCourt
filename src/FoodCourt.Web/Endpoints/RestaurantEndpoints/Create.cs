using FastEndpoints;
using FoodCourt.Core.RestaurantAggregate;
using FoodCourt.SharedKernel.Interfaces;

namespace FoodCourt.Web.Endpoints.RestaurantEndpoints;

public class Create : Endpoint<CreateRestaurantRequest, CreateRestaurantResponse>
{
  private readonly IRepository<Restaurant> _repository;

  public Create(IRepository<Restaurant> repository)
  {
    _repository = repository;
  }

  public override void Configure()
  {
     Post(CreateRestaurantRequest.Route);
     AllowAnonymous();
     Options(o => o.WithTags("RestaurantEndpoints"));

  }


  public override async Task HandleAsync(CreateRestaurantRequest req, CancellationToken ct)
  {
    if (!(req.Name?.Locals?.Any() ?? true))
    {
      ThrowError("Kindly Provide local names");
    }
    var restaurant = new Restaurant { LocalizedName = req.Name! };
    var response = await _repository.AddAsync(restaurant);
    await SendAsync(new CreateRestaurantResponse(response.Id , response.LocalizedName!));
  }
}
