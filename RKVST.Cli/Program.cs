using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
// registrations will go here

var provider = services.BuildServiceProvider();

Console.WriteLine("RKVST");
Console.WriteLine("Type 'help' for commands, 'exit' to quit.");
Console.WriteLine();

while (true)
{
    Console.Write("> ");
    var input = Console.ReadLine()?.Trim();

    if (string.IsNullOrEmpty(input)) continue;
    if (input == "exit") break;

    Console.WriteLine($"Unknown command: {input}");
}