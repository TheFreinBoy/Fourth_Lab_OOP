using System;
using System.Numerics;

class Program
{
    static void testAPlusBSquare<T>(T a, T b) where T : IMyNumber<T>
    {
        Console.WriteLine($"=== Starting testing (a+b)^2=a^2+2ab+b^2 with a = {a}, b = {b} ===");
        T aPlusB = a.Add(b);
        Console.WriteLine("(a + b) = " + aPlusB);
        Console.WriteLine("(a+b)^2 = " + aPlusB.Multiply(aPlusB));
        Console.WriteLine("= = = ");
        T aSquare = a.Multiply(a);
        Console.WriteLine("a^2 = " + aSquare);
        T ab = a.Multiply(b);
        T twoAB = ab.Add(ab);
        Console.WriteLine("2*a*b = " + twoAB);
        T bSquare = b.Multiply(b);
        Console.WriteLine("b^2 = " + bSquare);
        T result = aSquare.Add(twoAB).Add(bSquare);
        Console.WriteLine("a^2+2ab+b^2 = " + result);
        Console.WriteLine($"=== Finishing testing (a+b)^2=a^2+2ab+b^2 with a = {a}, b = {b} ===");
    }

    static void testSquaresDifference<T>(T a, T b) where T : IMyNumber<T>
    {
        Console.WriteLine($"=== Starting testing (a-b)^2 = a^2 - 2ab + b^2 with a = {a}, b = {b} ===");
        T aMinusB = a.Subtract(b);
        Console.WriteLine("(a - b) = " + aMinusB);
        Console.WriteLine("(a-b)^2 = " + aMinusB.Multiply(aMinusB));
        Console.WriteLine("= = = ");
        T aSquare = a.Multiply(a);
        Console.WriteLine("a^2 = " + aSquare);
        T ab = a.Multiply(b);
        T twoAB = ab.Add(ab);
        Console.WriteLine("2*a*b = " + twoAB);
        T bSquare = b.Multiply(b);
        Console.WriteLine("b^2 = " + bSquare);
        T result = aSquare.Subtract(twoAB).Add(bSquare);
        Console.WriteLine("a^2 - 2ab + b^2 = " + result);
        Console.WriteLine($"=== Finishing testing (a-b)^2 = a^2 - 2ab + b^2 with a = {a}, b = {b} ===");
    }

    static void Main(string[] args)
    {
        testAPlusBSquare(new MyFrac(1, 3), new MyFrac(1, 6));
        testAPlusBSquare(new MyComplex(1, 3), new MyComplex(1, 6));
        testSquaresDifference(new MyFrac(1, 3), new MyFrac(1, 6));
        testSquaresDifference(new MyComplex(1, 3), new MyComplex(1, 6));

        Console.WriteLine("Sorted fractions:");
        List<MyFrac> fractions = new List<MyFrac> { new MyFrac(1, 2), new MyFrac(1, 3), new MyFrac(3, 4) };
        fractions.Sort();
        foreach (var frac in fractions)
            Console.WriteLine(frac);

        Console.ReadKey();
    }
}
