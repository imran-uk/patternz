// See https://aka.ms/new-console-template for more information

// a little demo of the factory method pattern
// starting with anti way of doing it :)

// this class repserents the consumer

// lets create different types of Pizza

using System.Text.Json;
using patternz;

// TODO
// use readline shiz, see Atypical C# code
//var pizzaOrder = "cheese-tomato";
//var pizzaOrder = "spicy-veg";
var pizzaOrder = "cheese-veg-tuna";


// HOMEWORK
// find a design-pattern that will allow me to create ANY type of pizza
// eg. cheese, tomato, tuna etc
//
// hint: builder-pattern
// try to implement this builder!


// with previous code, if i add a new pizza type i need to change this code quite a bit eg. repeat the Bake / PutInBox and Deliver lines...
// can i leverage a pattern and improve code re-use ?

// hmm this seems...
var pizzaCreatorFactory = new PizzaCreatorFactory();
var pizzaCreator = pizzaCreatorFactory.GetPizzaCreator(pizzaOrder);

// now do the actions/logic common to all pizzas
// treat everying as an IPizza
// this code does not know or care what is in pizzaCreator, only that it can do pizza related stuff

// lets use the factory method, no "new" instance here

var pizza = pizzaCreator.CreatePizza();

Console.WriteLine($"my pizza is... {pizza}");

// SUMMARY
// the code that creates the pizza is seperated from the consumer (this program)
// so it makes it easy to extend the construction classes without impacting this one
// eg. what if we discover a fresher, newer way yo make CheeseTomatoPizza?

// to add a new Pizza we just create concrete IPizza and concrete ICreator class for it and then wire it up to this class (*the switch/case)
// THATS IT !
// minimal changes here! so we can have confidecne that we have not introduced regressopns/bugs (moar changes == moar bugz)