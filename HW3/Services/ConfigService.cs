using HW3.Configs;
using HW3.Models;
using HW3.Models.Enums;

namespace HW3.Services
{
    public class ConfigService
    {
        private static readonly ConfigService _instance = new ConfigService();
        static ConfigService()
        {
        }

        private ConfigService()
        {
            var config = GetConfig();
            SetingConfig = config.SetingConfig;
            ErreySize = config.ErreySize;
        }

        public SetingConfig SetingConfig { get; }
        public int ErreySize { get; }
        public static ConfigService Instance => _instance;

        private Config GetConfig()
        {
            return new Config
            {
                SetingConfig = new SetingConfig
                {
                    CurrencyData = new CurrencyData[]
                    {
                        new CurrencyData
                        {
                            Currency = Currency.USD,
                            RateDefaultToCurrency = 1
                        },
                        new CurrencyData
                        {
                            Currency = Currency.UAH,
                            RateDefaultToCurrency = 27
                        }
                    },
                    WeightUnitData = new WeightUnitData[]
                    {
                        new WeightUnitData
                        {
                            WeightUnit = WeightUnit.PNDS,
                            RateDefaultToWeightUnit = 1
                        },
                        new WeightUnitData
                        {
                            WeightUnit = WeightUnit.KG,
                            RateDefaultToWeightUnit = 0.453592
                        }
                    },
                    CurrentCurrency = Currency.USD,
                    CurrentWeightUnit = WeightUnit.PNDS,
                },
                ErreySize = 10
            };
        }
    }
}
