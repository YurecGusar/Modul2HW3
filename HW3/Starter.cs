using System;
using HW3.Services;
using HW3.Models.SweetnessTypes.ConfectioneryTypes.SugarConfectioneryTypes.CandyTypes;
using HW3.Models;

namespace HW3
{
    public class Starter
    {
        private PresentService _present = new PresentService();
        public void Run()
        {
            var present = _present.Present;
            var presentWeight = _present.GetPresentWeight();
            Console.WriteLine(presentWeight);
            Console.WriteLine(present.Sweetnesses[1].Currency);
        }
    }
}
