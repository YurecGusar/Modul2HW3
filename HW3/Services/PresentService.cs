using HW3.Models;
namespace HW3.Services
{
    public class PresentService
    {
        private SweetnessService _sweetnessService;

        public PresentService()
        {
            _sweetnessService = new SweetnessService();
            Present = GetPresent();
        }

        public PresentModel Present { get; set; }

        public double GetPresentWeight()
        {
            var weight = 0.0;
            foreach (var item in Present.Sweetnesses)
            {
                weight += item.Weight;
            }

            return weight;
        }/*

        public Models.Sweetness Add( ob present, string name)
        {

        }*/

        private PresentModel GetPresent()
        {
            return new PresentModel
            {
                Sweetnesses = _sweetnessService.GetAll()
            };
        }
    }
}
