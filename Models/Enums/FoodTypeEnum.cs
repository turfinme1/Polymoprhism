using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models.Enums
{
    [Flags]
    public enum FoodTypeEnum
    {
        Vegetable = 1,
        Fruit = 2,
        Meat = 4,
        Seeds= 8
    }
}
