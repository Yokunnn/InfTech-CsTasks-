using System;
using System.Collections.Generic;

namespace UtilLibrary
{
    abstract class DomesticMovie : Movie
    {
        public string Name { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public string Duration { get; set; }
        public string AddTitri()
        {
            return "Титры добавлены";
        }
        public List<string> Show()
        {
            List<string> res = new List<string>
            {
                AddTitri(),
                "Длительность фильма: " + Duration,
                "Происходит показ фильма " + Name,
                "Режиссер - " + Director,
                "Продюсер - " + Producer
            };
            return res;
        }
        public abstract string CustomizeGenre();
        public abstract string DistributeFee();
    }
}
