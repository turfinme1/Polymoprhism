using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models;
using WildFarm.Models.Interfaces;

namespace WildFarm.Factories
{
    public class AnimalFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal(params string[] animalParams)
        {   
            string type = animalParams[0];
            switch (type)
            {
                case "Cat":
                    return new Cat(animalParams[1], double.Parse(animalParams[2]), animalParams[3], animalParams[4]);
                case "Tiger":
                    return new Tiger(animalParams[1], double.Parse(animalParams[2]), animalParams[3], animalParams[4]);
                case "Dog":
                    return new Dog(animalParams[1], double.Parse(animalParams[2]), animalParams[3]);
                case "Mouse":
                    return new Mouse(animalParams[1], double.Parse(animalParams[2]), animalParams[3]);
                case "Owl":
                    return new Owl(animalParams[1], double.Parse(animalParams[2]), double.Parse(animalParams[3]));
                case "Hen":
                    return new Hen(animalParams[1], double.Parse(animalParams[2]), double.Parse(animalParams[3]));
                default:
                    throw new ArgumentException("Invalid input");
            }

        }

    }
}
