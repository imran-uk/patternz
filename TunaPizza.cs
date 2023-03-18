using System;

namespace patternz;

public class TunaPizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine($"baking the {this.GetType()} - yummy seafood and protein yo");
    }

    public void PutInBox()
    {
        Console.WriteLine($"puttin the {this.GetType()} in da box");
    }

    public void Deliver()
    {
        Console.WriteLine($"deliver the {this.GetType()}");
    }
}