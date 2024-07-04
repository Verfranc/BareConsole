using BareConsole;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder()
    .ConfigureServices(services =>
    {
        services.AddSingleton<BareMessage>();
    });
var host = builder.Build();
var bareMessage = host.Services.GetRequiredService<BareMessage>();

bareMessage.Run();

Console.WriteLine("Press Enter key to continue...");
Console.ReadLine();
