using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public abstract class Mammal : Animal, IMammal
    {
        protected Mammal(string name, double weight, string livingRegion, ICollection<FoodTypeEnum> foodPreference, double weightIncreaseParam) : base(name, weight, foodPreference, weightIncreaseParam)
        {
            LivingRegion = livingRegion;
        }

        public string LivingRegion { get; private set; }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
