using CalculatorStrategyDesignPattern.Interfaces;
using CalculatorStrategyDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStrategyDesignPattern.Context
{
    public class SalaryCalculator
    {
        private ISalaryCalculator _salaryCalculator;

        public SalaryCalculator(ISalaryCalculator salaryCalculator)
        {
            _salaryCalculator = salaryCalculator;
        }

        public void SetCalculator(ISalaryCalculator salaryCalculator) =>
            _salaryCalculator = salaryCalculator;

        public double Calculate(IEnumerable<DeveloperReport> developerReports) =>
            _salaryCalculator.CalculateTotalSalary(developerReports);
    }
}
