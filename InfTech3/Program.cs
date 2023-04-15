using System;

namespace InfTech3
{
    class Program
    {
        static void Main(string[] args)
        {
            TaksoPark park = new TaksoPark("ParkoTaks");
            park.Add(new Car("Volvo", 1000000, 200, 10.5f));
            park.Add(new Car("Cadillac", 1750000, 230, 12.8f));
            park.Add(new Car("Audi", 300000, 170, 9.2f));
            park.Add(new Car("BMW", 3000000, 213, 11.0f));
            park.Add(new Car("Chevrolet", 2375000, 190, 10.2f));

            Console.WriteLine(park.ToString());

            Console.WriteLine("Price of taksopark = " + park.getTaksoParkPrice());

            Console.WriteLine(string.Join("", park.SpeedInRange(190, 213)));

            park.SortByFuelWaste();
            Console.WriteLine(park.ToString());
        }
    }
}
