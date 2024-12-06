using Spectre.Console;
using System.Net.NetworkInformation;
public static class UptimeTracker
{
    public static async Task Main(string[] args)
    {
        AnsiConsole.Markup("[underline yellow]Uptime Tracker[/]\n");
        EndpointQuery endpointQuery = new EndpointQuery();
        Uri uri = new Uri("http://example.com");
        bool access = await endpointQuery.TestEnpoint(uri);
        if (access)
        {
            AnsiConsole.Markup("[green]Reachable[/]\n");
        }
        else
        {
            AnsiConsole.Markup("[red]Unreachable[/]\n");
        }
    }

}
