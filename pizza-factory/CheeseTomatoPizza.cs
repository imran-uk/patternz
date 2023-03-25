using System;

namespace patternz;

public class CheeseTomatoPizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine($"baking the {this.GetType()}");
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