using CalculatorStrategyDesignPattern.Models;
using CalculatorStrategyDesignPattern.Utils.Enums;

namespace CalculatorStrategyDesignPattern.Interfaces
{
    public interface ISalaryCalculator
    {
        DeveloperLevel Level {  get; }
        double CalculateTotalSalary(IEnumerable<DeveloperReport> developerReports);
    }
}
