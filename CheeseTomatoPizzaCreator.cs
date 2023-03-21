using System.Runtime.CompilerServices;

namespace patternz;

public class CheeseTomatoPizzaCreator : IPizzaCreator
{
    public IPizza CreatePizza()
    {
        Console.WriteLine($"created pizza, yummy cheese / {this.GetType()}");

        return new CheeseTomatoPizza();
    }

    public void DoStuffToPizza()
    {
        var pizza = CreatePizza();

        pizza.Bake();
        pizza.PutInBox();

        Console.WriteLine($"do stuff to this cheesy pizza / {this.GetType()}");
    }
}