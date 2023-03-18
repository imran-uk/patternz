using System;

namespace patternz;

public class CheeseTomatoPizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine($"baking the {typeof(CheeseTomatoPizza)}");
    }

    public void PutInBox()
    {
        Console.WriteLine($"puttin the {typeof(CheeseTomatoPizza)} in da box");
    }

    public void Deliver()
    {
        Console.WriteLine($"deliver the {typeof(CheeseTomatoPizza)}");
    }
}