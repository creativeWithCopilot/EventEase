using EventEase.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace EventEase;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        // Services
        builder.Services.AddScoped<SessionState>();
        builder.Services.AddSingleton<AttendanceService>();

        // Optional: Blazored.LocalStorage registration if you plan to use it later
        // builder.Services.AddBlazoredLocalStorage();

        await builder.Build().RunAsync();
    }
}
