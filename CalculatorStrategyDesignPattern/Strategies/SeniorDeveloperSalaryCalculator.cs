using CalculatorStrategyDesignPattern.Interfaces;
using CalculatorStrategyDesignPattern.Models;
using CalculatorStrategyDesignPattern.Utils.Enums;

namespace CalculatorStrategyDesignPattern.Strategies
{
    public class SeniorDeveloperSalaryCalculator : ISalaryCalculator
    {
        public DeveloperLevel Level => DeveloperLevel.Senior;

        public double CalculateTotalSalary(IEnumerable<DeveloperReport> developerReports) =>
            developerReports.Where(dr => dr.Level == DeveloperLevel.Senior)
            .Select(dr => dr.CalculateSalary() * 1.2)
            .Sum();

    }
}
