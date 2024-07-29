using CalculatorStrategyDesignPattern.Interfaces;
using CalculatorStrategyDesignPattern.Models;
using CalculatorStrategyDesignPattern.Utils.Enums;

namespace CalculatorStrategyDesignPattern.Strategies
{
    public class JuniorDeveloperSalaryCalculator : ISalaryCalculator
    {
        public DeveloperLevel Level => DeveloperLevel.Junior;

        public double CalculateTotalSalary(IEnumerable<DeveloperReport> developerReports) =>
            developerReports.Where(dr => dr.Level == DeveloperLevel.Junior)
            .Select(r => r.CalculateSalary())
            .Sum();

    }
}
