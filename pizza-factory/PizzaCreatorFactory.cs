namespace patternz;

internal class PizzaCreatorFactory
{
    public IPizzaCreator GetPizzaCreator(string pizzaOrder)
    {
        switch (pizzaOrder)
        {
            case "cheese-tomato":
                return new CheeseTomatoPizzaCreator();
            case "spicy-veg":
                return new SpicyVegPizzaCreator();
            case "tuna":
                return new TunaPizzaCreator();
            default:
                throw new Exception("un-supported pizza topping, sorry dude");
        }
    }

    public IPizzaCreator GetPizzaCreator2(string pizzaOrder) => pizzaOrder switch
    {
        "cheese-tomato" => new CheeseTomatoPizzaCreator(),
        "spicy-veg" => new SpicyVegPizzaCreator(),
        "tuna" => new TunaPizzaCreator(),
        _ => throw new Exception("un-supported pizza topping, sorry dude")
    };
}