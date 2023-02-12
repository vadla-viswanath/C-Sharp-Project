using System;

public class PersonTypeConstructors
{
    public static void Main(string[] args)
    {
        Person[] persons = new Person[3];

        for (int i = 0; i < 3; i++)
        {
            if (i == 0)
            {
                Console.Write("Enter teacher name: ");
                persons[i] = new Teacher(Console.ReadLine());
            }
            else
            {
                Console.Write("Enter student {0} name: ", i );
                persons[i] = new Student(Console.ReadLine());
            }
        }

        Console.WriteLine("============");
        Console.WriteLine("User details");
        Console.WriteLine("============");
        for (int i = 0; i < 3; i++)
        {
            
            if (i == 0)
            {
                Console.WriteLine("Teacher " + persons[i].ToString());
                ((Teacher)persons[i]).Explain();
            }
            else
            {
                Console.WriteLine("Student{0} " + persons[i].ToString(),i);
                ((Student)persons[i]).Study();
            }
            
        }
    }
    public class Student : Person
    {
        public Student(string name) : base(name)
        {
            Name = name;
        }
        public void Study()
        {
            Console.WriteLine("{0} is studying",Name);
        }
    }
    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
            Name = name;
        }
        public void Explain()
        {
            Console.WriteLine("{0} is explaining",Name);
        }
    }
    public class Person
    {
        public string Name;

        public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return "name is " + Name;
        }

    }
}