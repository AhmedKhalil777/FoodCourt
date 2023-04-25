using MudBlazor;
using MudBlazor.Services;

namespace FoodCourt.MAUI.Installers;
public static class MudInstaller
{

  public static IServiceCollection InstallMudServices(this IServiceCollection services)
  {
    return services.AddMudServices(configuration =>
            {
              configuration.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomRight;
              configuration.SnackbarConfiguration.HideTransitionDuration = 100;
              configuration.SnackbarConfiguration.ShowTransitionDuration = 100;
              configuration.SnackbarConfiguration.VisibleStateDuration = 3000;
              configuration.SnackbarConfiguration.ShowCloseIcon = false;
            });
  }
}
