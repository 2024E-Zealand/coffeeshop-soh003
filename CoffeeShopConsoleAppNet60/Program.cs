// See https://aka.ms/new-console-template for more information
using CoffeeShopConsoleAppNet60;

Console.WriteLine("KAFFER!");


BlackCoffee blackCoffee = new BlackCoffee();
Console.WriteLine($"Sort Kaffe, Strength: {blackCoffee.Strength()}: {blackCoffee.Price()} DKK" );
Console.WriteLine($"");

Latte latte = new Latte();
Console.WriteLine($"Latte, Strength: {latte.Strength()}: {blackCoffee.Price()+ 20} DKK");
Console.WriteLine($"ml Milk: {latte.mlMilk()}");

Cortado cortado = new Cortado();    
Console.WriteLine($"Cortado, Strength {cortado.Strength()}: {blackCoffee.Price() + 5} DKK");
Console.WriteLine($"ml Milk: {cortado.mlMilk()}");
