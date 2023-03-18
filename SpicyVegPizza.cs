using System;

namespace patternz;

public class SpicyVegPizza
{
    public void Bake()
    {
        Console.WriteLine($"baking the {typeof(SpicyVegPizza)}");
    }

    public void PutInBox()
    {
        Console.WriteLine($"puttin the {typeof(SpicyVegPizza)} in da box");
    }

    public void Deliver()
    {
        Console.WriteLine($"deliver the {typeof(SpicyVegPizza)}");
    }
}