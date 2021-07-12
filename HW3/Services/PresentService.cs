using HW3.Models;
using HW3.Models.SweetnessTypes.ConfectioneryTypes.SugarConfectioneryTypes;

namespace HW3.Services
{
    public class PresentService
    {
        private SweetnessService _sweetnessService;
        private ConfigService _config = ConfigService.Instance;
        private static readonly PresentService _instance = new PresentService();
        private int _counter;
        private Candy[] _present;

        static PresentService()
        {
        }

        private PresentService()
        {
            Init();
            _sweetnessService = new SweetnessService();
            _counter = 0;
            Present = _present;
        }

        public Candy[] Present { get; }

        public static PresentService Instance => _instance;

        public void Add(string name)
        {
            _present[_counter] = _sweetnessService.FindByName(name);
            _counter++;
        }

        public double GetTotalWeight()
        {
            var weight = 0.0;
            foreach (var item in Present)
            {
                if (item != null)
                {
                    weight += item.Weight;
                }
            }

            return weight;
        }

        private void Init()
        {
            _present = new Candy[_config.ErreySize];
        }
    }
}
