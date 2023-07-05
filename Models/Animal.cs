using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public abstract class Animal : IAnimal
    {
        private ICollection<FoodTypeEnum> foodPreference;
        private double weightIncreaseParam;
        protected Animal(string name, double weight, ICollection<FoodTypeEnum> foodPreference, double weightIncreaseParam)
        {
            Name = name;
            Weight = weight;
            this.foodPreference = foodPreference;
            this.weightIncreaseParam = weightIncreaseParam;
        }

        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        public void Feed(FoodTypeEnum food, int quantity)
        {
            if (!foodPreference.Contains(food))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food}!");
            }

            FoodEaten += quantity;
            Weight += quantity * weightIncreaseParam;

        }

        public abstract string Sound();
        public abstract new  string ToString();
    }
}
