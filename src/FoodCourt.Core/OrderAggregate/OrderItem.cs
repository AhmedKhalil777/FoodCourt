using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodCourt.SharedKernel;

namespace FoodCourt.Core.OrderAggregate;
public class OrderItem : EntityBase
{
  public int MealItemId { get; set; }

  public int Count { get; set; }
}
