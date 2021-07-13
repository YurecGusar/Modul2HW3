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
        private Sweetness[] _present;

        static PresentService()
        {
        }

        private PresentService()
        {
            Init();
            _sweetnessService = new SweetnessService();
            _counter = 0;
        }

        public static PresentService Instance => _instance;

        public void Add(Sweetness sweet)
        {
            _present[_counter] = sweet;
            _counter++;
        }

        public double GetTotalWeight()
        {
            var weight = 0.0;
            foreach (var item in _present)
            {
                if (item != null)
                {
                    weight += item.Weight;
                }
            }

            return weight;
        }

        public Sweetness[] GetPresent()
        {
            return _present;
        }

        private void Init()
        {
            _present = new Candy[_config.ErreySize];
        }
    }
}
