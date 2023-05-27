using System;
using System.Collections.Generic;

namespace InfTech5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            Comedy comedy1 = new Comedy()
            {
                Name = "Smeshariki",
                Director = "Krosh",
                Producer = "Ezhik",
                Duration = "20min",
                LaughLevel = Comedy.ComedyRate.MEDIUM,
                ChildAllowed = true
            };
            Comedy comedy2 = new Comedy()
            {
                Name = "Mask",
                Director = "Chuck Russel",
                Producer = "Bob Engelman",
                Duration = "101min",
                LaughLevel = Comedy.ComedyRate.HIGH,
                ChildAllowed = false
            };
            Comedy comedy3 = new Comedy()
            {
                Name = "Voronini",
                Director = "Muzhik",
                Producer = "Tozhe muzhik",
                Duration = "30min",
                LaughLevel = Comedy.ComedyRate.LOW,
                ChildAllowed = true
            };
            movies.Add(comedy1);
            movies.Add(comedy2);
            movies.Add(comedy3);
            foreach(Comedy comedy in movies)
            {
                comedy.CustomizeGenre();
                comedy.DistributeFee();
                comedy.WarnAudience();
                comedy.Show();
                comedy.PlayFunnyMusic();
                Console.WriteLine();
            }
        }
    }
}
