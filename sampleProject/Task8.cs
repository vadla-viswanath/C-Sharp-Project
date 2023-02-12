using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace newSpace
{

    class Person
    {
        static void Main(string[] args)
        {
            String[] user = new String[10];
            int[] age = new int[10];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter person{0} name: ", i + 1);
                user[i] = Convert.ToString(Console.ReadLine());
                Console.Write("Enter person{0} age: ", i + 1);
                age[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("============");
            Console.WriteLine("User details");
            Console.WriteLine("============");
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Person{0} name is " + user[j], j + 1);
                Console.WriteLine("Person{0} age is " + age[j], j + 1);
            }
        }

    }
}