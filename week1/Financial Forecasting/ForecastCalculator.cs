using System;

namespace FinancialForecasting
{
    public class ForecastCalculator
    {
        // Recursive method to calculate future value
        public static double CalculateFutureValue(double initialAmount, double growthRate, int years)
        {
            if (years == 0)
                return initialAmount;

            return CalculateFutureValue(initialAmount, growthRate, years - 1) * (1 + growthRate / 100);
        }
    }
}
