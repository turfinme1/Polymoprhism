using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Cat : Feline
    {
        private static readonly FoodTypeEnum[] foodPreference =
        {
            FoodTypeEnum.Meat,
            FoodTypeEnum.Vegetable
        };
        private const double WeightIncreaseParam = 0.3;
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed, foodPreference, WeightIncreaseParam)
        {
        }

        public override string Sound()
        {
            return "Meow";
        }
    }
}
