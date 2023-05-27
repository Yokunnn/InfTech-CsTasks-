using System;
using System.Collections.Generic;
using System.Text;

namespace UtilLibrary
{
    class Drama : DomesticMovie
    {
        public enum TearfullnessRate
        {
            LOW,
            MEDIUM,
            HIGH,
            PLAKPLAK
        }
        public TearfullnessRate Tearfullness { get; set; }
        public bool IsFamilyMovie { get; set; }
        public override string CustomizeGenre()
        {
            return "Это будет драма";
        }

        public override string DistributeFee()
        {
            return "Большие гонорары для талантливых актеров";
        }
        public string PlaySadMusic()
        {
            return "Турурурурурурурурурруур";
        }
        public List<string> GiveForeword()
        {
            List<string> res = new List<string>();
            switch (Tearfullness)
            {
                case TearfullnessRate.LOW:
                    res.Add(":|");
                    break;
                case TearfullnessRate.MEDIUM:
                    res.Add(":(");
                    break;
                case TearfullnessRate.HIGH:
                    res.Add(";(((");
                    break;
                case TearfullnessRate.PLAKPLAK:
                    res.Add("T~T");
                    break;
            }
            if (IsFamilyMovie)
            {
                res.Add("Семейный фильм");
            }
            else
            {
                res.Add("Лучше посмотреть в одиночку");
            }
            return res;
        }
    }
}
