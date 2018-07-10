using System;
namespace StaticVar{
public class Variable
{
    public static double x = 0;
    public void test()
    {
        x = Math.Pow(5, 2);
        Console.WriteLine(x);
    }
}


public class StaticVar
{
    static void Main()
    {
        Variable var = new Variable();
        var.test();
        
    }
}
}
