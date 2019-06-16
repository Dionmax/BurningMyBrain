using System;
public class Program
{
    public static void Main()
    {
        double? x = null;
        double? y = null;
        double a;
        double b;

        Console.WriteLine(y.GetValueOrDefault());

        a = x ?? 5.0;

        Console.WriteLine(a);
    }
}