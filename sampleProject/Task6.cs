using System;
public class CheckIsNumber
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Value:");
        string text = Console.ReadLine();
        if (IsNumber(text))
        {
            Console.WriteLine("Input is number");
        }
        else
        {
            Console.WriteLine("Input is not a number");
        }
    }

    public static bool IsNumber(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if ((text[i] < '0') || (text[i] > '9'))
            {
                return false;
            }
        }

        return true;
    }
}