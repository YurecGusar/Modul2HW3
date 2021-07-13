using HW3.Models.Enums;

namespace HW3.Models.SweetnessTypes
{
    public abstract class Confectionery : Sweetness
    {
        public Ingredients[] Ingredients { get; set; }
        public double SugarPercent { get; set; }
    }
}
