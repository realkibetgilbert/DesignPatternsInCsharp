using CalculatorStrategyDesignPattern.Context;
using CalculatorStrategyDesignPattern.Interfaces;
using CalculatorStrategyDesignPattern.Strategies;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CalculatorStrategyDesignPattern
{
    public class ServiceManager
    {

        public static IServiceProvider CreateServiceProvider()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(ConfigureServices)
                .Build();
            return host.Services;
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ISalaryCalculator, JuniorDeveloperSalaryCalculator>();
            services.AddTransient<ISalaryCalculator, SeniorDeveloperSalaryCalculator>();
            services.AddTransient<SalaryCalculator>();

        }
    }
}
