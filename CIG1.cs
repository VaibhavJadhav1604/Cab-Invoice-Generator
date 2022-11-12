using System;

namespace CIG1
{
    public class Fare
    {
        public double CostPerKm = 10;
        public int CostPerMinute = 1;
        public int MinimumFare = 5;
        public double CalculateFare(double Distance, int time)
        {
            double Fare = (CostPerKm * Distance) + (CostPerMinute * time);
            return Math.Max(Fare, MinimumFare);
        }
    }
    internal class CIG1
    {
        static void Main(string[] args)
        {
            
        }
    }
}
