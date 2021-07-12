using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW3.Models;
using HW3.Models.Enums;
using HW3.Models.SweetnessTypes.ConfectioneryTypes.SugarConfectioneryTypes;
using HW3.Models.SweetnessTypes.ConfectioneryTypes.SugarConfectioneryTypes.CandyTypes;

namespace HW3.Services
{
    public class SweetnessService
    {
        private ConfigService _config;
        private Providers.SweetnessProvider _sweetnessProvider;
        private Candy[] _candys;

        public SweetnessService()
        {
            _config = ConfigService.Instance;
            _sweetnessProvider = new Providers.SweetnessProvider();
            _candys = GetAll();
        }

        public Candy[] GetAll()
        {
            var result = _sweetnessProvider.GetAll();
            ConvertCurrency(result);
            ConvertWeight(result);
            return result;
        }

        public Candy FindByName(string name)
        {
            foreach (var item in _candys)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }

            return null;
        }

        private void ConvertCurrency(Candy[] candy)
        {
            foreach (var item in candy)
            {
                var currency = GetCurrencyData(item.Currency);
                item.Price = item.Price * currency.RateDefaultToCurrency;
            }
        }

        private void ConvertWeight(Candy[] candy)
        {
            foreach (var item in candy)
            {
                var weightUnit = GetWeightUnitData(item.WeightUnit);
                item.Weight = item.Weight * weightUnit.RateDefaultToWeightUnit;
            }
        }

        private CurrencyData GetCurrencyData(Currency currency)
        {
            foreach (var item in _config.SetingConfig.CurrencyData)
            {
                if (item.Currency == currency)
                {
                    return item;
                }
            }

            return null;
        }

        private WeightUnitData GetWeightUnitData(WeightUnit weightUnit)
        {
            foreach (var item in _config.SetingConfig.WeightUnitData)
            {
                if (item.WeightUnit == weightUnit)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
