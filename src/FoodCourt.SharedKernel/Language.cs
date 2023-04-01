using Ardalis.SmartEnum;

namespace FoodCourt.SharedKernel;
public class Language : SmartEnum<Language>
{
  public static readonly Language Arabic = new(nameof(Arabic), 0);
  public static readonly Language English = new(nameof(English), 1);
  public static readonly Language French = new(nameof(French), 2);
  public static readonly Language Slovenian = new(nameof(Slovenian), 3);
  public static readonly Language Dutch = new(nameof(Dutch), 4);
  protected Language(string name, int value) : base(name, value){ }

}
