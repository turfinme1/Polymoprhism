using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Enums;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Food : IFood
    {
        public Food(int quantity, FoodTypeEnum type)
        {
            Quantity = quantity;
            Type = type;
        }

        public int Quantity { get; private set; }

        public FoodTypeEnum Type { get; private set; }
    }
}
