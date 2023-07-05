using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Factories;
using WildFarm.Models;
using WildFarm.Models.Enums;
using WildFarm.Models.Interfaces;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        private readonly IAnimalFactory animalFactory;
        private readonly ICollection<IAnimal> animalCollection;

        public Engine(IAnimalFactory animalFactory)
        {
            this.animalFactory = animalFactory;
            animalCollection = new List<IAnimal>();
        }

        public void Run()
        {

            while (true)
            {
                string animalTokens = Console.ReadLine();
                if (animalTokens == "End")
                {
                    break;
                }
                string foodTokens = Console.ReadLine();

                try
                {
                    IAnimal animal = ProccessAnimalTokens(animalTokens);
                    IFood food = ProccessFoodTokens(foodTokens);
                    animalCollection.Add(animal);

                    Console.WriteLine(animal.Sound());
                    animal.Feed(food);

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var animal in animalCollection)
            {
                Console.WriteLine(animal.ToString());
            }
        }

        private IAnimal ProccessAnimalTokens(string animalTokens)
        {
            ArgumentNullException.ThrowIfNull(animalTokens);
            string[] animalParams = animalTokens.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            return animalFactory.CreateAnimal(animalParams);
        }
        private IFood ProccessFoodTokens(string foodTokens)
        {
            string[] foodParams = foodTokens.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Enum.TryParse(typeof(FoodTypeEnum), foodParams[0], out var foodType);
            if (foodType is null)
            {
                throw new ArgumentException("Invalid input");
            }
            int quantity = int.Parse(foodParams[1]);
            return new Food(quantity, (FoodTypeEnum)foodType);
        }
    }
}

