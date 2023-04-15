using System;
using System.Collections.Generic;
using System.Text;

namespace InfTech4
{
    class CoolMatchBox : MatchBox
    {
        private int defectPercentage;
        public CoolMatchBox(string companyName, int amount, int unitBurningTime, int defectPercentage)
            : base(companyName, amount, unitBurningTime)
        {
            if(defectPercentage < 0)
            {
                defectPercentage = 0;
            } else if(defectPercentage > 100)
            {
                defectPercentage = 100;
            }
            this.defectPercentage = defectPercentage;
        }

        public override int Quantity()
        {
            return (100 - defectPercentage) * base.Quantity() / 100;
        }
        public override string ToString()
        {
            string answer = base.ToString();
            answer += "defectPercentage: " + defectPercentage.ToString() + "\n";
            return answer;
        }
    }
}
