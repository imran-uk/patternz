// See https://aka.ms/new-console-template for more information

// a little demo of the factory method pattern
// starting with anti way of doing it :)

// this class repserents the consumer

// lets create different types of Pizza

using patternz;

// TODO
// use readline shiz, see Atypical C# code
//var pizzaOrder = "cheese-tomato";
var pizzaOrder = "spicy-veg";

// with previous code, if i add a new pizza type i need to change this code quite a bit eg. repeat the Bake / PutInBox and Deliver lines...
// can i leverage a pattern and improve code re-use ?

// hmm this seems...
IPizzaCreator pizzaCreator = default!;

switch (pizzaOrder)
{
    case "cheese-tomato":
        pizzaCreator = new CheeseTomatoPizzaCreator();
        break;
    case "spicy-veg":
        pizzaCreator = new SpicyVegPizzaCreator();
        break;
    default:
        throw new Exception("un-supported pizza topping, sorry dude");
}

// now do the actions/logic common to all pizzas
// treat everying as an IPizza
// this code does not know or care what is in pizzaCreator, only that it can do pizza related stuff

// lets use the factory method, no "new" instance here
var pizza = pizzaCreator.CreatePizza();
pizza.Bake();
pizza.PutInBox();
pizza.Deliver();