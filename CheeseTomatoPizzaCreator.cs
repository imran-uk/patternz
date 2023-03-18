namespace patternz;

public class CheeseTomatoPizzaCreator : IPizzaCreator
{
    public IPizza CreatePizza()
    {
        return new CheeseTomatoPizza();
    }
}