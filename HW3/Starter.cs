using System;
using HW3.Services;

namespace HW3
{
    public class Starter
    {
        private ConfigService _configService = ConfigService.Instance;
        public void Run()
        {
            Console.WriteLine(_configService.SetingConfig.CurrencyData[1].RateDefaultToCurrency);
            var x = 500;
            var y = 50;
            Console.WriteLine(Math.Round((double)(x * y / 100)));
        }
    }
}
