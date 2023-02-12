using System;

public class PersonTypeConstructors2
{
    public static void Main(string[] args)
    {
        Person[] persons = new Person[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter person {0} name: ", i + 1);
            persons[i] = new Person(Console.ReadLine());
        }
        /*Console.WriteLine("============");
        Console.WriteLine("User details");
        Console.WriteLine("============");
        for (int i = 0; i < 3; i++)
        {
            persons[i].ToString(i);
        }*/
    }
    public class Student2 : Person
    {
        public Student2(string name) : base(name)
        {
        }

        public void Study()
        {
            Console.WriteLine("Student studying");
        }
    }
    public class Teacher2 : Person
    {
        public Teacher2(string name) : base(name)
        {
        }

        public void Explain()
        {
            Console.WriteLine("Teacher explaining");
        }
    }
    public class Person
    {
        public string Name;

        public Person(string name)
        {
            Name = name;
        }

        public void ToString(int i)
        {
            Console.WriteLine("Person {0} name is " + Name, i + 1);
        }

        ~Person()
        {
            Name = "";
        }
    }
}