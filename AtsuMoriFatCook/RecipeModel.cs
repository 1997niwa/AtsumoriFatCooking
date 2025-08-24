using AtsuMoriFatCook.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtsuMoriFatCook
{
    internal class RecipeModel
    {
        internal string Name { get; private set; }
        internal int Price { get; private set; }
        internal int Flour { get; private set; }
        internal int WholeWheatFlour { get; private set; }
        internal int Sugar { get; private set; }
        internal int BrownSugar { get; private set; }
        internal int TomatoPuree { get; private set; }
        internal int Potato { get; private set; }
        internal int Carrot { get; private set; }
        internal int Tomato { get; private set; }
        internal int Pumpkin { get; private set; }
        internal int Apple { get; private set; }
        internal int Orange { get; private set; }
        internal int Pear { get; private set; }
        internal int Peach { get; private set; }
        internal int Cherry { get; private set; }
        internal int Coconut { get; private set; }

        //設定名、売値、こむぎこ、ぜんりゅうふん、さとう、こくとう、トマトピューレ、じゃがいも、にんじん、トマト、かぼちゃ、リンゴ、オレンジ、ナシ、モモ、さくらんぼ、ヤシのみ
        internal RecipeModel(String name, int price, int flour, int wholeWheatFlour, int sugar, int brownSugar, int tomatoPuree, int potato, int carrot, int tomato, int pumpkin, int apple, int orange, int pear, int peach, int cherry, int coconut)
        {
            Name = name;
            Price = price;
            Flour = flour;
            WholeWheatFlour = wholeWheatFlour;
            Sugar = sugar;
            BrownSugar = brownSugar;
            TomatoPuree = tomatoPuree;
            Potato = potato;
            Carrot = carrot;//8
            Tomato = tomato;//7
            Pumpkin = pumpkin;//6
            Apple = apple;//5
            Orange = orange;//4
            Pear = pear;//3
            Peach = peach;//2
            Cherry = cherry;//1
            Coconut = coconut;//0
        }
    }
}


