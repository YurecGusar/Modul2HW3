using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW3.Models.Enums;
using HW3.Models.SweetnessTypes.ConfectioneryTypes.SugarConfectioneryTypes;
using HW3.Models.SweetnessTypes.ConfectioneryTypes.SugarConfectioneryTypes.CandyTypes;

namespace HW3.Providers
{
    public class SweetnessProvider
    {
        private readonly Candy[] _sweetness;
        public SweetnessProvider()
        {
            _sweetness = new Candy[]
            {
                new CaramelCandy
                {
                    Name = "Малибу",
                    CalorieContent = 24.3,
                    Weight = 2,
                    Price = 40,
                    Ingredients = new Ingredients[]
                    {
                        Ingredients.Sugar,
                        Ingredients.Water,
                        Ingredients.Vinegar,
                        Ingredients.VegetableOil
                    },
                    SugarPercent = 90,
                    Taste = Taste.Sweet,
                    CandyWrapper = CandyWrapper.Sock,
                    Wand = true
                },
                new CaramelCandy
                {
                    Name = "Ключик",
                    CalorieContent = 2.3,
                    Weight = 4,
                    Price = 12,
                    Ingredients = new Ingredients[]
                    {
                        Ingredients.Sugar,
                        Ingredients.Water,
                        Ingredients.Vinegar,
                        Ingredients.VegetableOil,
                        Ingredients.Honey
                    },
                    SugarPercent = 90,
                    Taste = Taste.Sweet,
                    CandyWrapper = CandyWrapper.Twisting,
                    Wand = false
                },
                new FondantCandy
                {
                     Name = "Помадка",
                     CalorieContent = 1.5,
                     Weight = 2,
                     Price = 4,
                     Ingredients = new Ingredients[]
                     {
                        Ingredients.Sugar,
                        Ingredients.CondensedMilk,
                        Ingredients.Water,
                        Ingredients.Butter
                     },
                     SugarPercent = 87,
                     Taste = Taste.Sour,
                     CandyWrapper = CandyWrapper.Sachet,
                     FondantType = FondantType.Basic
                }
            };
        }

        public Candy[] GetAll()
        {
            return _sweetness;
        }
    }
}
