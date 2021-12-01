using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PwaFoodServiceBlazor.Service;
using PwaFoodServiceBlazor.Service.Interface;
using PwaFoodServiceBlazor.Util;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PwaFoodServiceBlazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSingleton<HttpClient>();
            builder.Services.AddSingleton<IJsonAutoMapper, JsonAutoMapperGeneric>();
            builder.Services.AddSingleton<ICardapioService, CardapioService>();
            builder.Services.AddSingleton<IMesaService, MesaService>();
            builder.Services.AddSingleton<IClienteService, ClienteService>();
            builder.Services.AddBlazoredLocalStorage();
            await builder.Build().RunAsync();
        }
    }
}
