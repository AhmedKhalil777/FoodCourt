using System.ComponentModel.DataAnnotations.Schema;
using FoodCourt.SharedKernel.Interfaces;

namespace FoodCourt.SharedKernel;

// This can be modified to EntityBase<TId> to support multiple key types (e.g. Guid)
public abstract class EntityBase : IAuditable
{
  public int Id { get; set; }

  public DateTime Created { get; set; }
  public string CreatedBy { get; set; } = string.Empty;
  public DateTime CreatedByDateTime { get; set; }
  public string LastModifiedBy { get; set; } = string.Empty;
  public DateTime LastModifiedByDateTime { get; set; }

  private List<DomainEventBase> _domainEvents = new ();
  [NotMapped]
  public IEnumerable<DomainEventBase> DomainEvents => _domainEvents.AsReadOnly();

  protected void RegisterDomainEvent(DomainEventBase domainEvent) => _domainEvents.Add(domainEvent);
  internal void ClearDomainEvents() => _domainEvents.Clear();
}
