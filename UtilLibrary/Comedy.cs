using System;
using System.Collections.Generic;
using System.Text;

namespace UtilLibrary
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
        public override string CustomizeGenre()
        {
            return "Внимание, комедия!";
        }
        public override string DistributeFee()
        {
            return "Установлены небольшие гонорары";
        }
        public string PlayFunnyMusic()
        {
            return "Парарарам парам пам";
        }
        public List<string> WarnAudience()
        {
            List<string> res = new List<string>();
            switch (LaughLevel)
            {
                case ComedyRate.LOW:
                    res.Add("Фильм на улыбнуться");
                    break;
                case ComedyRate.MEDIUM:
                    res.Add("Смешной фильм");
                    break;
                case ComedyRate.HIGH:
                    res.Add("Хахахахахахахахахахахахахахахахахаха");
                    break;
            }
            if (ChildAllowed)
            {
                res.Add("Можно смотреть с детьми");
            }
            else
            {
                res.Add("Уберите детей от экрана");
            }
            return res;
        }
    }
}
