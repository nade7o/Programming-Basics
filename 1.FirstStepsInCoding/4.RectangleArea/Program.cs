using System;

public class Program
{
    public static void Main()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var area = a * b;
        Console.WriteLine("Rectangle area is " + area);
    }
}