namespace patternz;

public class TunaPizzaCreator : IPizzaCreator
{
    public IPizza CreatePizza()
    {
        return new TunaPizza();
    }
}