using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtsuMoriFatCook.Ingredient
{
    internal class IngredientModel
    {
        internal IngredientEnum Name { get; private set; }
        internal int Price { get; private set; }

        internal IngredientModel(IngredientEnum name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
