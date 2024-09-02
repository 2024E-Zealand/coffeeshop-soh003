// See https://aka.ms/new-console-template for more information
using CoffeeShopConsoleAppNet60;

Console.WriteLine("KAFFER!");


BlackCoffee blackCoffee = new BlackCoffee(0);
Console.WriteLine($"Sort Kaffe, Strength: {blackCoffee.Strength()}: {blackCoffee.Price()} DKK" );
Console.WriteLine($"");

Latte latte = new Latte(0);
Console.WriteLine($"Latte, Strength: {latte.Strength()}: {latte.Price()} DKK");
Console.WriteLine($"ml Milk: {latte.mlMilk()}");
Console.WriteLine($"");

Cortado cortado = new Cortado(0);    
Console.WriteLine($"Cortado, Strength {cortado.Strength()}: {cortado.Price()} DKK");
Console.WriteLine($"ml Milk: {cortado.mlMilk()}");
