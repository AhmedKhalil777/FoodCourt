using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;


namespace FoodCourt.MAUI.Installers;
public static class ClientsInstaller
{
  private const string ClientName = "FoodCourt.MAUI";

  public static IServiceCollection InstallClients(this IServiceCollection services)
  {
    string url;

#if DEBUG
    url = "https://localhost:5001";
#else
    url = "";
#endif

    services.AddScoped(sp => sp
                    .GetRequiredService<IHttpClientFactory>()
                    .CreateClient(ClientName))
             .AddHttpClient(ClientName, client => client.BaseAddress = new Uri(url));
     return services;

  }
}
