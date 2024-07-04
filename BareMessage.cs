using Microsoft.Extensions.Configuration;

namespace BareConsole;

public class BareMessage (IConfiguration configuration)
{
    public void Run()
    {
        Console.WriteLine(configuration["Message"]);
    }
}
