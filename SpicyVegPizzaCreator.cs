namespace patternz;

public class SpicyVegPizzaCreator : IPizzaCreator
{
    public IPizza CreatePizza()
    {
        return new SpicyVegPizza();
    }
}