using System;
using HW3.Services;
using HW3.Models.SweetnessTypes.ConfectioneryTypes.SugarConfectioneryTypes.CandyTypes;
using HW3.Models;

namespace HW3
{
    public class Starter
    {
        private PresentService _present;
        private SweetnessService _sweetnessService;

        public Starter()
        {
            _present = PresentService.Instance;
            _sweetnessService = new SweetnessService();
        }

        public void Run()
        {
            var present = _present.Present;
            _present.Add("Малибу");
            _present.Add("Ключик");
            Console.WriteLine(_present.GetTotalWeight());
        }
    }
}
