// See https://aka.ms/new-console-template for more information
using ConsoleApp5;
using System.Security;
Console.WriteLine("Joes's Pizza details");
PizzaManagement pm = new PizzaManagement();
foreach(var p in pm.AllPizzas())
{
    Console.WriteLine(p.Id);
    Console.WriteLine(p.Name);
    Console.WriteLine(p.Price);
}
