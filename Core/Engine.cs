using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models;
using WildFarm.Models.Interfaces;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string type = data[0];
            string name = data[1];
            double weight = double.Parse(data[2]);
            string livingRegion = data[3];
            string breed = data[4];
            IAnimal cat = new Cat(name, weight, livingRegion, breed);

            var food = Console.ReadLine().Split();
            FoodTypeEnum foodType = (FoodTypeEnum)Enum.Parse(typeof(FoodTypeEnum), food[0]);
            int quantity = int.Parse(food[1]);
            cat.Feed(foodType, quantity);
            Console.WriteLine(cat.Sound());
            Console.WriteLine(cat.ToString());
        }
    }
}

