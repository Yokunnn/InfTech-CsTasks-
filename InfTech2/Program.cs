using System;
using System.IO;

namespace InfTech2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter k");
            int k = int.Parse(Console.ReadLine());
            SplitText("Name0.txt", k, "Name1.txt", "Name2.txt");
        }

        static void SplitText(string Name0, int k, string Name1, string Name2)
        {
            StreamReader reader = new StreamReader(Name0);
            StreamWriter writer1 = new StreamWriter(Name1);
            StreamWriter writer2 = new StreamWriter(Name2);
            for(int i = 0; i < k; i++)
            {
                writer1.WriteLine(reader.ReadLine());
            }
            writer2.Write(reader.ReadToEnd());
            reader.Close();
            writer1.Close();
            writer2.Close();
        }
    }
}
