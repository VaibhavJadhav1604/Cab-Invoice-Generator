using System;

namespace CIG3
{
    public class multiplerides
    {
        public double distance;
        public int time;
        public multiplerides(double distance, int time)
        {
            this.time = time;
            this.distance = distance;
        }
    }
    public class ride
    {
        public int counter;
        public double costperkm = 10;
        public int costperminute = 1;
        public int minimumfare = 5;
        public double calculatefare(double distance, int time)
        {
            counter++;
            double fare = (costperkm * distance) + (costperminute * time);
            return Math.Max(fare, minimumfare);
        }
        public double calculatefare(multiplerides[] ride)
        {
            double totalfare = 0;
            foreach (multiplerides rides in ride)
            {
                totalfare = totalfare + calculatefare(rides.distance, rides.time);
            }
            return totalfare;
        }

    }
    public class CIG3
    {
        static void Main(string[] args)
        {
            ride r = new ride();
            multiplerides[] mr= { new multiplerides(20, 10), new multiplerides(10, 20) };
            double total = r.calculatefare(mr);
            Console.WriteLine("Total Rides Are:" + r.counter);
            Console.WriteLine("Total Fare Is:"+ total);
            double avg = total / r.counter;
            Console.WriteLine("Average Fare Is:"+ avg);
        }
    }
}
