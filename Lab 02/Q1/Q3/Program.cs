using System;

namespace TemperatureTrackerApp
{
    class TemperatureTracker
    {
        private double[] dailyTemperatures;

        public TemperatureTracker(double[] temperatures)
        {
            if (temperatures.Length == 7)
            {
                dailyTemperatures = temperatures;
            }
            else
            {
                Console.WriteLine("Invalid number of temperatures entered.");
                dailyTemperatures = new double[7];
            }
        }

        public void DisplayTemperatures()
        {
            Console.WriteLine("Weekly Temperature Report:\n");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Day " + (i + 1) + ": " + dailyTemperatures[i] + "°C");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double[] weeklyTemperatures = { 25.5, 26.0, 24.5, 27.5, 28.0, 26.5, 27.0 };
            TemperatureTracker tracker = new TemperatureTracker(weeklyTemperatures);

            tracker.DisplayTemperatures();

            Console.ReadKey();
        }
    }
}
