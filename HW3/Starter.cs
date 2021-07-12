using System;
using HW3.Services;
using HW3.Models.SweetnessTypes.ConfectioneryTypes.SugarConfectioneryTypes.CandyTypes;
using HW3.Models;

namespace HW3
{
    public class Starter
    {
        private ConfigService _configService = ConfigService.Instance;
        public void Run()
        {
            Sweetness korowka = new CaramelCandy();
            korowka.Name = "Korowka";
            korowka.Currency = _configService.SetingConfig.CurrentCurrency;
            korowka.Price = 24 * _configService.SetingConfig.CurrencyData[0].RateDefaultToCurrency;
            Console.WriteLine($"{korowka.Name} {korowka.Currency} {korowka.Price}");
        }
    }
}
