using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Dog : Mammal
    {
        private static readonly FoodTypeEnum[] foodPreference =
        {
            FoodTypeEnum.Meat,
        };
        private const double WeightIncreaseParam = 0.4;

        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion, foodPreference, WeightIncreaseParam)
        {
        }

        public override string Sound()
        {
            return "Woof!";
        }
    }
}
