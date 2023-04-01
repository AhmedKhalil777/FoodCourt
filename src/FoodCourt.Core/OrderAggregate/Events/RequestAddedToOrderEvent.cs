using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodCourt.SharedKernel;

namespace FoodCourt.Core.OrderAggregate.Events;
public class RequestAddedToOrderEvent : DomainEventBase
{
  public int RequestId { get; set; }
  public OrderRequest Request { get; set; } = new();
  public RequestAddedToOrderEvent(int requestId, OrderRequest request)
  {
    RequestId = requestId;
    Request = request;
  }

}
