using System;
using System.Collections.Generic;
using System.Text;

namespace UtilLibrary
{
    class Horror : DomesticMovie
    {
        public string Scare { get; set; }
        public List<string> Contraindications { get; set; }
        public override string CustomizeGenre()
        {
            return "Всем бояться! Это ужасы";
        }

        public override string DistributeFee()
        {
            return "Установлены средние гонорары";
        }
        public List<string> ShowContraindications()
        {
            List<string> res = new List<string>
            {
                "Противопоказания к просмотру:"
            };
            foreach(string str in Contraindications)
            {
                res.Add("###-" + str);
            }
            return res;
        }
        public string Boo()
        {
            return "........" + Scare + "..." + Scare + ".--.-..........";
        }
    }
}
