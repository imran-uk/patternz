namespace patternz;

class Pizza : IPizza
{
    private readonly List<string> _ingredients;

    public Pizza(List<string> ingredients)
    {
        _ingredients = ingredients;
    }

    public void Bake()
    {
        Console.WriteLine($"baking the {string.Join(",", _ingredients)}");
    }

    public void PutInBox()
    {
        Console.WriteLine($"puttin the {string.Join(",", _ingredients)} in da box");
    }

    public void Deliver()
    {
        Console.WriteLine($"deliver the {string.Join(",", _ingredients)}");
    }
}