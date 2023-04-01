using Ardalis.ApiEndpoints;
using FoodCourt.Core.RestaurantAggregate;
using FoodCourt.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace FoodCourt.Web.Endpoints.RestaurantEndpoints;

public class List : EndpointBaseAsync
  .WithoutRequest
  .WithActionResult<RestaurantListResponse>
{
  private readonly IRepository<Restaurant> _repository;

  public List(IRepository<Restaurant> repository)
  {
    _repository = repository;
  }

  [HttpGet("/Restaurants")]
  [SwaggerOperation(
    Summary = "Gets a list of all Restaurants",
    Description = "Gets a list of all Restaurants",
    OperationId = "Restaurants.List",
    Tags = new[] { "RestaurantsEndpoints" })
  ]
  public override async Task<ActionResult<RestaurantListResponse>> HandleAsync(CancellationToken cancellationToken = default)
  {
    var restaurants = await _repository.ListAsync(cancellationToken);
    var res = new RestaurantListResponse
    {
      Restaurants = restaurants.Select(r=> new RestaurantRecord(r.Id, r.LocalizedName))
    };
    return Ok(res);
  }
}
