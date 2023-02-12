using System;
public class ProductOfNumber
{
    public static void Main(string[] args)
    {
        Console.Write("Enter first value: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second value: ");
        int y = Convert.ToInt32(Console.ReadLine());

        int result = 0;
        for (int i = 0; i < y; i++)
        {
            result = result + x;
        }

        Console.WriteLine("Multiple of two numbers: {0}x{1}= {2}", x, y, result);
    }
}