using System;
using System.Collections.Generic;
using System.Text;

namespace InfTech4
{
    class MatchBox
    {
        private string companyName;

        private int amount;

        private int unitBurningTime;

        public MatchBox(string companyName, int amount, int unitBurningTime)
        {
            this.companyName = companyName;
            this.amount = amount;
            this.unitBurningTime = unitBurningTime;
        }
        public virtual int Quantity()
        {
            return amount * unitBurningTime;
        }
        public override string ToString()
        {
            string answer = base.ToString() + ":\n";
            answer += "companyName: " + companyName + "\n";
            answer += "amount: " + amount.ToString() + "\n";
            answer += "unitBurningTime: " + unitBurningTime.ToString() + "\n";
            return answer;
        }
    }
}
