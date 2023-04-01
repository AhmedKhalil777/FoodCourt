namespace FoodCourt.SharedKernel.Interfaces;
public interface IAuditable
{
  public string CreatedBy { get; set; }
  public DateTime CreatedByDateTime { get; set; }
  public string LastModifiedBy { get; set; }
  public DateTime LastModifiedByDateTime { get; set; }

}
