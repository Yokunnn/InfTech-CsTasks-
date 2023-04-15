using System;
using System.Collections.Generic;
using System.Text;

namespace InfTech3
{
    class TaksoPark
    {
        private string name;
        private List<Car> cars;

        public TaksoPark(string name)
        {
            this.name = name;
        }


        public int getTaksoParkPrice()
        {
            int sum = 0;
            foreach(Car car in cars)
            {
                sum += car.getPrice();
            }
            return sum;
        }
        public void SortByFuelWaste()
        {
            cars.Sort(new Comparison<Car>(
                (x,y) => x.getFuelWaste().CompareTo(y.getFuelWaste())
                ));
        }
        public List<Car> SpeedInRange(int min, int max)
        {
            List<Car> answer = new List<Car>();
            foreach(Car car in cars)
            {
                if (min <= car.getMaxSpeed() & car.getMaxSpeed() <= max)
                {
                    answer.Add(car);
                }
            }
            answer.Sort(new Comparison<Car>(
                (x,y) => x.getMaxSpeed().CompareTo(y.getMaxSpeed())
                ));
            return answer;
        }

        public void Add(Car car)
        {
            if (cars == null)
            {
                cars = new List<Car>
                {
                    car
                };
            } else
            {
                cars.Add(car);
            }
        }

        public override string ToString()
        {
            string answer = base.ToString() + ": {\n";
            answer += "~name: " + name + "\n";
            foreach(Car car in cars)
            {
                answer += "~" + car.ToString();
            }
            answer += "}\n";
            return answer;
        }
    }
}
