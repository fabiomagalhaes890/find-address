// See https://aka.ms/new-console-template for more information
using Question2.Application;

Console.WriteLine("Welcome to ZBRA test!");

var exit = false;

while (!exit)
{
    Console.WriteLine("Select an option: \r\n 1 - Address \r\n 0 - Exit");
    var message = string.Empty;
    var number = Console.ReadLine();
    
    if (int.Parse(number ?? "0") == 1)
    {
        var address = ApplicationAddressService.SearchAddress();
        Console.WriteLine(String.Format("The Address number is {0}.", address));
    }
    else if(int.Parse(number ?? "0") == 0)
    {
        Environment.Exit(0);
    }
}