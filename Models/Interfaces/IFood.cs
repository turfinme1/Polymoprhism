using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models.Interfaces
{
    public interface IFood
    {
        public int Quantity { get; }
        public  FoodTypeEnum Type { get; }
    }
    public enum FoodTypeEnum
    {
        Vegetable,
        Fruit,
        Meat,
        Seeds
    }
}
