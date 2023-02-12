using System;
public class Exercise10
{
    public static void Main()
    {
        int[] inputArray = new int[10];
        int[] ouputArray = new int[10];
        int j = 0;


        Console.WriteLine("Integers to be stored in the array");
        int n = 4;

        Console.WriteLine("Input {0} integers in the array :", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write("Input element - {0} : ", i);
            inputArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            if (inputArray[i] % 2 == 0)
            {
                ouputArray[j] = inputArray[i];
                j++;
            }
        }

        Console.Write("\nThe Even integers are : \n");
        for (int i = 0; i < j; i++)
        {
            Console.Write("{0} ", ouputArray[i]);
        }
    }
}