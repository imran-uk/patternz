// See https://aka.ms/new-console-template for more information

// a little demo of the factory method pattern
// starting with anti way of doing it :)

// this class repserents the consumer

// lets create different types of Pizza

//namespace patternz;

using patternz;

var order = "cheese-tomato";

if(order == "cheese-tomato")
{
    Console.WriteLine($"Here is your cheese-tomato pizza");

    var pizza = new CheeseTomatoPizza();
    pizza.Bake();
    pizza.PutInBox();
    pizza.Deliver();
}
else if(order == "spicy-veg")
{
    Console.WriteLine($"Here is your cheese-tomato pizza");

    var pizza = new SpicyVegPizza();
    pizza.Bake();
    pizza.PutInBox();
    pizza.Deliver();
}

//Console.WriteLine("Hello, World!");