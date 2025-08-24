using AtsuMoriFatCook.Properties;
using AtsuMoriFatCook.Recipe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtsuMoriFatCook.Ingredient
{
    internal class IngredientList
    {
        private static string? _defaultFruits;
        
        private const int DEFAULT_FRUITS_PRICE = 100;
        private const int IMPORTED_FRUITS_PRICE = 500;
        
        internal IngredientList(string defaultFruits)
        {
            _defaultFruits = defaultFruits;
        }

        private static int FruitsPrice(string fruitName)
        {
            return fruitName == _defaultFruits ? DEFAULT_FRUITS_PRICE : IMPORTED_FRUITS_PRICE;
        }

        internal List<IngredientModel> SettingItems { get; private set; } = new List<IngredientModel>
        {
            new IngredientModel("こむぎこ", 175),
            new IngredientModel("ぜんりゅうふん", 175),
            new IngredientModel("さとう", 175),
            new IngredientModel("こくとう", 175),
            new IngredientModel("トマトピューレ", 1050),
            new IngredientModel("じゃがいも", 350),
            new IngredientModel("にんじん", 350),
            new IngredientModel("トマト", 350),
            new IngredientModel("かぼちゃ", 350),
            new IngredientModel("リンゴ", FruitsPrice("リンゴ")),
            new IngredientModel("オレンジ", FruitsPrice("オレンジ")),
            new IngredientModel("ナシ", FruitsPrice("ナシ")),
            new IngredientModel("モモ", FruitsPrice("モモ")),
            new IngredientModel("さくらんぼ", FruitsPrice("さくらんぼ")),
            new IngredientModel("ヤシのみ", 250)
        };
    }
}
