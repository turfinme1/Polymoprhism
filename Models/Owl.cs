using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Owl : Bird
    {
        private static readonly FoodTypeEnum[] foodPreference = { FoodTypeEnum.Meat };
        private const double WeightIncreaseParam = 0.25;

        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize, foodPreference, WeightIncreaseParam)
        {
        }

        public override string Sound()
        {
            return "Hoot Hoot";
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
