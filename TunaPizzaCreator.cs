namespace patternz;

public class TunaPizzaCreator : IPizzaCreator
{
    public IPizza CreatePizza()
    {
        Console.WriteLine($"created pizza, fish protein yo / {this.GetType()}");

        return new TunaPizza();
    }

    public void DoStuffToPizza()
    {
        var pizza = CreatePizza();

        pizza.Bake();
        pizza.PutInBox();

        Console.WriteLine($"do stuff to this tuna pizza / {this.GetType()}");
    }
}