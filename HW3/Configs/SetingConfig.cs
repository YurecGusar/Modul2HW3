using System;
using HW3.Models;
using HW3.Models.Enums;

namespace HW3.Configs
{
    public class SetingConfig
    {
        public CurrencyData[] CurrencyData { get; set; }
        public Currency CurrentCurrency { get; set; }
        public WeightUnitData[] WeightUnitData { get; set; }
        public WeightUnit CurrentWeightUnit { get; set; }
    }
}
