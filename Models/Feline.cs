using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Enums;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public abstract class Feline : Mammal, IFeline
    {
        protected Feline(string name, double weight, string livingRegion,string breed, FoodTypeEnum foodPreference, double weightIncreaseParam) 
            : base(name, weight, livingRegion, foodPreference, weightIncreaseParam)
        {
            Breed = breed;
        }

        public string Breed { get; private set; }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
