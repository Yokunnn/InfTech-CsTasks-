using System;
using System.Collections.Generic;
using System.Text;

namespace InfTech5
{
    class Comedy : DomesticMovie
    {
        public enum ComedyRate
        {
            LOW,
            MEDIUM,
            HIGH
        }
        public ComedyRate LaughLevel { get; set; }
        public bool ChildAllowed { get; set; }
        public override void CustomizeGenre()
        {
            Console.WriteLine("Внимание, комедия!");
        }
        public override void DistributeFee()
        {
            Console.WriteLine("Установлены небольшие гонорары");
        }
        public void PlayFunnyMusic()
        {
            Console.WriteLine("Парарарам парам пам");
        }
        public void WarnAudience()
        {
            switch(LaughLevel)
            {
                case ComedyRate.LOW:
                    Console.WriteLine("Фильм на улыбнуться");
                    break;
                case ComedyRate.MEDIUM:
                    Console.WriteLine("Смешной фильм");
                    break;
                case ComedyRate.HIGH:
                    Console.WriteLine("Хахахахахахахахахахахахахахахахахаха");
                    break;
            }
            if(ChildAllowed)
            {
                Console.WriteLine("Можно смотреть с детьми");
            } 
            else
            {
                Console.WriteLine("Уберите детей от экрана");
            }
        }
    }
}
