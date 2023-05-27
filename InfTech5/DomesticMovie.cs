using System;
using System.Collections.Generic;
using System.Text;

namespace InfTech5
{
    abstract class DomesticMovie : Movie
    {
        public string Name { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public string Duration { get; set; }
        public void AddTitri()
        {
            Console.WriteLine("Титры добавлены");
        }
        public void Show()
        {
            AddTitri();
            Console.WriteLine("Длительность фильма: " + Duration);
            Console.WriteLine("Происходит показ фильма " + Name);
            Console.WriteLine("Режиссер - " + Director);
            Console.WriteLine("Продюсер - " + Producer);
        }
        public abstract void CustomizeGenre();
        public abstract void DistributeFee();
    }
}
