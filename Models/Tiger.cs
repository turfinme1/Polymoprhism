using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Tiger : Feline
    {
        private static readonly FoodTypeEnum[] foodPreference =
        {
            FoodTypeEnum.Meat,
        };
        private const double WeightIncreaseParam = 1;

        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed, foodPreference, WeightIncreaseParam)
        {
        }

        public override string Sound()
        {
            return "ROAR!!!";
        }
    }
}
