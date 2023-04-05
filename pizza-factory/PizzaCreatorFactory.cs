namespace patternz;

internal class PizzaCreatorFactory
{
    // ingrediants are like
    // "cheese-tomato-tuna"
    // "spice-tuna"
    //
    // or if known type then use that one eg. spice-veg -> SpicyVegPizzaCreator

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
                // call custom pizza creator
                return new CustomPizzaCreator(pizzaOrder);
        }
    }

    public IPizzaCreator GetPizzaCreator2(string pizzaOrder) => pizzaOrder switch
    {
        "cheese-tomato" => new CheeseTomatoPizzaCreator(),
        "spicy-veg" => new SpicyVegPizzaCreator(),
        "tuna" => new TunaPizzaCreator(),
        _ => throw new Exception("un-supported pizza topping, sorry dude")
    };

    // how to easily support more pizza types eg. chicken

}

// this should use the builder
public class CustomPizzaCreator : IPizzaCreator
{
    private readonly PizzaBuilder _builder = new PizzaBuilder();

    private readonly List<string> _toppings;
    
    public CustomPizzaCreator(string pizzaOrder)
    {
        _toppings = pizzaOrder.Split("-").ToList();
    }

    public IPizza CreatePizza()
    {
        foreach (var topping in _toppings)
        {
            switch (topping)
            {
                // switch case for each
                case "cheese":
                    _builder.AddCheese();
                    break;
                case "tomato":
                    _builder.AddTomato();
                    break;
                case "tuna":
                    _builder.AddTuna();
                    break;
                case "veg":
                    _builder.AddVeg();
                    break;
                case "spice":
                    _builder.AddSpice();
                    break;
                // add default to throw exception
                default:
                    throw new Exception("un-supported pizza topping, sorry dude");
            }
        }

        return _builder.MakePizza();
    }
}


public class PizzaBuilder 
{
    //IPizza 
    private List<string> _toppings = new List<string>();

    public void Reset()
    {
        _toppings = new List<string>();
    }

    public PizzaBuilder AddCheese()
    {
        _toppings.Add("cheese");
        return this;
    }

    public PizzaBuilder AddTomato()
    {
        _toppings.Add("tomato");
        return this;
    }

    public PizzaBuilder AddTuna()
    {
        _toppings.Add("tuna");
        return this;
    }

    public PizzaBuilder AddVeg()
    {
        _toppings.Add("veg");
        return this;
    }

    public PizzaBuilder AddSpice()
    {
        _toppings.Add("spice");
        return this;
    }

    public IPizza MakePizza()
    {
        Console.WriteLine($"creating pizza, with these toppings: {string.Join(", ", _toppings)}");

        return new Pizza(_toppings);
    }
}
