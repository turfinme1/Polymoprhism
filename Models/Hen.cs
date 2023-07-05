using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Enums;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Hen : Bird
    {
        private static readonly FoodTypeEnum foodPreference =
            FoodTypeEnum.Fruit | FoodTypeEnum.Vegetable | FoodTypeEnum.Meat | FoodTypeEnum.Seeds;

        private const double WeightIncreaseParam = 0.35;

        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize, foodPreference, WeightIncreaseParam)
        {
        }

        public override string Sound()
        {
            return "Cluck";
        }
    }
}
