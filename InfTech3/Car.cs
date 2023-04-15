using System;
using System.Collections.Generic;
using System.Text;

namespace InfTech3
{
    class Car
    {
        private int price;

        private string name;

        private int maxSpeed;

        private float fuelWaste;

        public Car(string name, int price, int maxSpeed, float fuelWaste)
        {
            this.name = name;
            this.price = price;
            this.maxSpeed = maxSpeed;
            this.fuelWaste = fuelWaste;
        }

        public override string ToString()
        {
            string answer = base.ToString() + ": {\n";
            answer += "-name: " + name + ",\n";
            answer += "-price: " + price.ToString() + ",\n";
            answer += "-maxSpeed: " + maxSpeed.ToString() + ",\n";
            answer += "-fuelWaste: " + fuelWaste.ToString() + "\n";
            answer += "}\n";
            return answer;
        }

        public int getMaxSpeed()
        {
            return maxSpeed;
        }

        public int getPrice()
        {
            return price;
        }

        public float getFuelWaste()
        {
            return fuelWaste;
        }

        public string getName()
        {
            return name;
        }
    }
}
