namespace AtsuMoriFatCook.Ingredient
{
    internal class IngredientList
    {
        private static IngredientEnum _defaultFruits;

        private const int DEFAULT_FRUITS_PRICE = 100;
        private const int IMPORTED_FRUITS_PRICE = 500;

        internal IngredientList(string defaultFruits)
        {
            _defaultFruits = ConvertFruitsName(defaultFruits);
        }

        private IngredientEnum ConvertFruitsName(string fruitName)
        {
            return fruitName switch
            {
                "リンゴ" => IngredientEnum.Apple,
                "オレンジ" => IngredientEnum.Orange,
                "ナシ" => IngredientEnum.Pear,
                "モモ" => IngredientEnum.Peach,
                "さくらんぼ" => IngredientEnum.Cherry,
                _ => throw new ArgumentException("Invalid fruit name", nameof(fruitName)),
            };
        }

        private static int FruitsPrice(IngredientEnum ingredient)
        {
            return ingredient == _defaultFruits ? DEFAULT_FRUITS_PRICE : IMPORTED_FRUITS_PRICE;
        }

        internal List<IngredientModel> IngredientItems { get; private set; } = new List<IngredientModel>
        {
            new IngredientModel(IngredientEnum.Flour, 175),
            new IngredientModel(IngredientEnum.WholeWheatFlour, 175),
            new IngredientModel(IngredientEnum.Sugar, 175),
            new IngredientModel(IngredientEnum.BrownSugar, 175),
            new IngredientModel(IngredientEnum.TomatoPuree, 1050),
            new IngredientModel(IngredientEnum.Potato, 350),
            new IngredientModel(IngredientEnum.Carrot, 350),
            new IngredientModel(IngredientEnum.Tomato, 350),
            new IngredientModel(IngredientEnum.Pumpkin, 350),
            new IngredientModel(IngredientEnum.Apple, FruitsPrice(IngredientEnum.Apple)),
            new IngredientModel(IngredientEnum.Orange, FruitsPrice(IngredientEnum.Orange)),
            new IngredientModel(IngredientEnum.Pear, FruitsPrice(IngredientEnum.Pear)),
            new IngredientModel(IngredientEnum.Peach, FruitsPrice(IngredientEnum.Peach)),
            new IngredientModel(IngredientEnum.Cherry, FruitsPrice(IngredientEnum.Cherry)),
            new IngredientModel(IngredientEnum.Coconut, 250)
        };

        internal string GetIngredientName(IngredientEnum ingredient)
        {
            return ingredient switch
            {
                IngredientEnum.Flour => "こむぎこ",
                IngredientEnum.WholeWheatFlour => "ぜんりゅうふん",
                IngredientEnum.Sugar => "さとう",
                IngredientEnum.BrownSugar => "こくとう",
                IngredientEnum.TomatoPuree => "トマトピューレ",
                IngredientEnum.Potato => "じゃがいも",
                IngredientEnum.Carrot => "にんじん",
                IngredientEnum.Tomato => "トマト",
                IngredientEnum.Pumpkin => "かぼちゃ",
                IngredientEnum.Apple => "リンゴ",
                IngredientEnum.Orange => "オレンジ",
                IngredientEnum.Pear => "ナシ",
                IngredientEnum.Peach => "モモ",
                IngredientEnum.Cherry => "さくらんぼ",
                IngredientEnum.Coconut => "ヤシのみ",
                _ => throw new ArgumentException("Invalid ingredient", nameof(ingredient)),
            };
        }
    }
}
