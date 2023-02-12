using System;


namespace MyApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car(0);
            Console.Write("Enter amount : ");
            int gasoline = int.Parse(Console.ReadLine());
            if (car.refuel(gasoline))
            {
                car.Drive();
            }
        }



        public class Car : IVehicle
        {
            public int fuel = 0;
            public Car(int amount)
            {
                fuel = amount;
            }
            public void Drive()
            {
                if (fuel > 0)
                {
                    Console.WriteLine("Car is Driving");
                }
                else
                {
                    Console.WriteLine("Car is stopped due to low fuel");
                }

            }
            public bool Refuel(int gasoline)
            {
                fuel = fuel + gasoline;
                return true;
            }
        }

        public interface IVehicle
        {
            public void Drive();

            public bool Refuel(int gasoline);
        }
    }
}