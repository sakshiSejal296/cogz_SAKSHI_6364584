using System;

namespace FinancialForecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialAmount = 10000; // ₹10,000 starting
            double growthRate = 8;        // 8% annual growth
            int years = 5;

            double futureValue = ForecastCalculator.CalculateFutureValue(initialAmount, growthRate, years);
            Console.WriteLine($"Future value after {years} years: ₹{futureValue:F2}");

            Console.ReadLine();
        }
    }
}
