using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using MudBlazor.Services;
using Stroom.Client.Services;

namespace Stroom.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddHttpClient("Stroom.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("Stroom.ServerAPI"));

            builder.Services.AddApiAuthorization();
            builder.Services.AddMudServices();

            builder.Services.AddScoped<IProjectsService, TestProjectsService>();
            builder.Services.AddScoped<ITasksService, TestTasksService>();
            builder.Services.AddScoped<ITimeEntriesService, TimeEntriesService>();
            builder.Services.AddScoped<IUsersService, UsersService>();
            builder.Services.AddScoped<IClipboardService, ClipboardService>();

            await builder.Build().RunAsync();
        }
    }
}