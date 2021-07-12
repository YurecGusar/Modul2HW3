using System;

namespace HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = Services.ConfigService.Instance;
            var starter = new Starter();
            starter.Run();
            config.SetingConfig.CurrentWeightUnit = Models.Enums.WeightUnit.KG;
            Console.WriteLine(config.SetingConfig.CurrentWeightUnit);
        }
    }
}
