using HW3.Models.Enums;

namespace HW3.Models
{
    public abstract class Sweetness
    {
        public string Name { get; set; }
        public double CalorieContent { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public WeightUnit WeightUnit { get; set; }
        public Currency Currency { get; set; }
    }
}
