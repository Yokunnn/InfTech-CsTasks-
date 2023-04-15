using System;

namespace InfTech4
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchBox box1 = new MatchBox("Narodnaya", 100, 12);

            Console.Write(box1.ToString());
            Console.WriteLine("Box1 quantity = " + box1.Quantity() + "\n");

            CoolMatchBox box2 = new CoolMatchBox("Pravoslavnaya", 130, 15, -123);
            Console.Write(box2.ToString());
            Console.WriteLine("Box2 quantity = " + box2.Quantity());
        }
    }
}
