using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Mouse : Mammal
    {
        private static readonly FoodTypeEnum[] foodPreference =
        {
            FoodTypeEnum.Fruit,
            FoodTypeEnum.Vegetable,
        };
        private const double WeightIncreaseParam = 0.1;


        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion, foodPreference, WeightIncreaseParam)
        {

        }

        public override string Sound()
        {
            return "Squeak";
        }
    }
}
