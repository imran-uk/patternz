namespace patternz;

public class SpicyVegPizzaCreator : IPizzaCreator
{
    public IPizza CreatePizza()
    {
        Console.WriteLine($"created a spicy pizza, caution: hot!");

        return new SpicyVegPizza();
    }

    public void DoStuffToPizza()
    {
        var pizza = CreatePizza();

        pizza.Bake();
        // i'm too spicy for this box :D
        //pizza.PutInBox();

        Console.WriteLine($"do stuff to this spicy pizza / {this.GetType()}");
    }
}