using System;

public class AbstractClass
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog();
        Console.Write("Enter dog name : ");
        dog.SetName(Console.ReadLine());
        dog.Eat(dog.GetName());
    }

    public class Dog : Animal
    {
        public override void Eat(string name)
        {
            Console.WriteLine(name + " is Eating");
        }
    }

    public abstract class Animal
    {
        private string Name;

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public abstract void Eat(string name);
    }
}