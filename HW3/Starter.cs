using System;
using HW3.Helpers;
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
            var sweet = _sweetnessService.GetAll();
            var present = _present.GetPresent();
            _present.Add(sweet[0]);
            _present.Add(sweet.FindBName("Ключик"));
            var sweetInPresent = present.FindBName("Малибу");
            Console.WriteLine(_present.GetTotalWeight());
        }
    }
}
