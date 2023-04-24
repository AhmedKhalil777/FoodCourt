namespace FoodCourt.Web;

public static class TimespanExtension
{
  public static TimeSpan Minutes(this int num) => TimeSpan.FromMinutes(num);
  public static TimeSpan Seconds(this int num) => TimeSpan.FromSeconds(num);
  public static TimeSpan Hours(this int num) => TimeSpan.FromHours(num);
}
