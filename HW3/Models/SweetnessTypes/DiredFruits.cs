namespace HW3.Models.SweetnessTypes
{
    public abstract class DiredFruits : Sweetness
    {
        public Enums.Fruit Fruit { get; set; }
        public double WoterPercent { get; set; }
    }
}
