using AtsuMoriFatCook.Ingredient;
using AtsuMoriFatCook.Properties;
using AtsuMoriFatCook.Recipe;

namespace AtsuMoriFatCook
{
    internal class Calculator
    {
        private RecipeList _recipeList;
        private IngredientList _ingredientList;

        internal Calculator(RecipeList recipeList, IngredientList ingredientList)
        {
            _recipeList = recipeList;
            _ingredientList = ingredientList;

        }

        internal int[] CalculateAllAddedRecipe()
        {
            int[] addedRecipes = new int[_ingredientList.IngredientItems.Count];
            var values = (IngredientEnum[])Enum.GetValues(typeof(IngredientEnum));

            for (int i = 0; i < _ingredientList.IngredientItems.Count; i++)
            {
                addedRecipes[i]= CalculateAddedRecipe(values[i]);
            }
            return addedRecipes;
        }

        private int CalculateAddedRecipe(IngredientEnum ingredient)
        {

            if (ingredient == IngredientEnum.Flour)
            {
                int addedValue = 0;
                int candidateRecipe = 999;

                for (int i = 0; i < _recipeList.RecipeItems.Count; i++)
                {
                    if (_recipeList.RecipeItems[i].Flour != 0 && (int)Setting.Default[_recipeList.RecipeItems[i].Name] == 1)
                    {
                        int addedValueOfTheRecipe = CalculateAddedValue(i);
                        if (addedValue < addedValueOfTheRecipe)
                        {
                            addedValue = addedValueOfTheRecipe;
                            candidateRecipe = i;
                        }
                    }
                }
                return candidateRecipe;
            }

            if (ingredient == IngredientEnum.WholeWheatFlour)
            {
                int addedValue = 0;
                int candidateRecipe = 999;

                for (int i = 0; i < _recipeList.RecipeItems.Count; i++)
                {
                    if (_recipeList.RecipeItems[i].WholeWheatFlour != 0 && (int)Setting.Default[_recipeList.RecipeItems[i].Name] == 1)
                    {
                        int addedValueOfTheRecipe = CalculateAddedValue(i);
                        if (addedValue < addedValueOfTheRecipe)
                        {
                            addedValue = addedValueOfTheRecipe;
                            candidateRecipe = i;
                        }
                    }
                }
                return candidateRecipe;
            }

            if (ingredient == IngredientEnum.Sugar)
            {
                int addedValue = 0;
                int candidateRecipe = 999;

                for (int i = 0; i < _recipeList.RecipeItems.Count; i++)
                {
                    if (_recipeList.RecipeItems[i].Sugar != 0 && (int)Setting.Default[_recipeList.RecipeItems[i].Name] == 1)
                    {
                        int addedValueOfTheRecipe = CalculateAddedValue(i);
                        if (addedValue < addedValueOfTheRecipe)
                        {
                            addedValue = addedValueOfTheRecipe;
                            candidateRecipe = i;
                        }
                    }
                }
                return candidateRecipe;
            }

            if (ingredient == IngredientEnum.BrownSugar)
            {
                int addedValue = 0;
                int candidateRecipe = 999;

                for (int i = 0; i < _recipeList.RecipeItems.Count; i++)
                {
                    if (_recipeList.RecipeItems[i].BrownSugar != 0 && (int)Setting.Default[_recipeList.RecipeItems[i].Name] == 1)
                    {
                        int addedValueOfTheRecipe = CalculateAddedValue(i);
                        if (addedValue < addedValueOfTheRecipe)
                        {
                            addedValue = addedValueOfTheRecipe;
                            candidateRecipe = i;
                        }
                    }
                }
                return candidateRecipe;
            }

            if (ingredient == IngredientEnum.TomatoPuree)
            {
                int addedValue = 0;
                int candidateRecipe = 999;

                for (int i = 0; i < _recipeList.RecipeItems.Count; i++)
                {
                    if (_recipeList.RecipeItems[i].TomatoPuree != 0 && (int)Setting.Default[_recipeList.RecipeItems[i].Name] == 1)
                    {
                        int addedValueOfTheRecipe = CalculateAddedValue(i);
                        if (addedValue < addedValueOfTheRecipe)
                        {
                            addedValue = addedValueOfTheRecipe;
                            candidateRecipe = i;
                        }
                    }
                }
                return candidateRecipe;
            }

            if (ingredient == IngredientEnum.Potato)
            {
                int addedValue = 0;
                int candidateRecipe = 999;

                for (int i = 0; i < _recipeList.RecipeItems.Count; i++)
                {
                    if (_recipeList.RecipeItems[i].Potato != 0 && (int)Setting.Default[_recipeList.RecipeItems[i].Name] == 1)
                    {
                        int addedValueOfTheRecipe = CalculateAddedValue(i);
                        if (addedValue < addedValueOfTheRecipe)
                        {
                            addedValue = addedValueOfTheRecipe;
                            candidateRecipe = i;
                        }
                    }
                }
                return candidateRecipe;
            }

            if (ingredient == IngredientEnum.Carrot)
            {
                int addedValue = 0;
                int candidateRecipe = 999;

                for (int i = 0; i < _recipeList.RecipeItems.Count; i++)
                {
                    if (_recipeList.RecipeItems[i].Carrot != 0 && (int)Setting.Default[_recipeList.RecipeItems[i].Name] == 1)
                    {
                        int addedValueOfTheRecipe = CalculateAddedValue(i);
                        if (addedValue < addedValueOfTheRecipe)
                        {
                            addedValue = addedValueOfTheRecipe;
                            candidateRecipe = i;
                        }
                    }
                }
                return candidateRecipe;
            }

            if (ingredient == IngredientEnum.Tomato)
            {
                int addedValue = 0;
                int candidateRecipe = 999;

                for (int i = 0; i < _recipeList.RecipeItems.Count; i++)
                {
                    if (_recipeList.RecipeItems[i].Tomato != 0 && (int)Setting.Default[_recipeList.RecipeItems[i].Name] == 1)
                    {
                        int addedValueOfTheRecipe = CalculateAddedValue(i);
                        if (addedValue < addedValueOfTheRecipe)
                        {
                            addedValue = addedValueOfTheRecipe;
                            candidateRecipe = i;
                        }
                    }
                }
                return candidateRecipe;
            }

            if (ingredient == IngredientEnum.Pumpkin)
            {
                int addedValue = 0;
                int candidateRecipe = 999;

                for (int i = 0; i < _recipeList.RecipeItems.Count; i++)
                {
                    if (_recipeList.RecipeItems[i].Pumpkin != 0 && (int)Setting.Default[_recipeList.RecipeItems[i].Name] == 1)
                    {
                        int addedValueOfTheRecipe = CalculateAddedValue(i);
                        if (addedValue < addedValueOfTheRecipe)
                        {
                            addedValue = addedValueOfTheRecipe;
                            candidateRecipe = i;
                        }
                    }
                }
                return candidateRecipe;
            }

            if (ingredient == IngredientEnum.Apple)
            {
                int addedValue = 0;
                int candidateRecipe = 999;

                for (int i = 0; i < _recipeList.RecipeItems.Count; i++)
                {
                    if (_recipeList.RecipeItems[i].Apple != 0 && (int)Setting.Default[_recipeList.RecipeItems[i].Name] == 1)
                    {
                        int addedValueOfTheRecipe = CalculateAddedValue(i);
                        if (addedValue < addedValueOfTheRecipe)
                        {
                            addedValue = addedValueOfTheRecipe;
                            candidateRecipe = i;
                        }
                    }
                }
                return candidateRecipe;
            }

            if (ingredient == IngredientEnum.Orange)
            {
                int addedValue = 0;
                int candidateRecipe = 999;

                for (int i = 0; i < _recipeList.RecipeItems.Count; i++)
                {
                    if (_recipeList.RecipeItems[i].Orange != 0 && (int)Setting.Default[_recipeList.RecipeItems[i].Name] == 1)
                    {
                        int addedValueOfTheRecipe = CalculateAddedValue(i);
                        if (addedValue < addedValueOfTheRecipe)
                        {
                            addedValue = addedValueOfTheRecipe;
                            candidateRecipe = i;
                        }
                    }
                }
                return candidateRecipe;
            }

            if (ingredient == IngredientEnum.Pear)
            {
                int addedValue = 0;
                int candidateRecipe = 999;

                for (int i = 0; i < _recipeList.RecipeItems.Count; i++)
                {
                    if (_recipeList.RecipeItems[i].Pear != 0 && (int)Setting.Default[_recipeList.RecipeItems[i].Name] == 1)
                    {
                        int addedValueOfTheRecipe = CalculateAddedValue(i);
                        if (addedValue < addedValueOfTheRecipe)
                        {
                            addedValue = addedValueOfTheRecipe;
                            candidateRecipe = i;
                        }
                    }
                }
                return candidateRecipe;
            }

            if (ingredient == IngredientEnum.Peach)
            {
                int addedValue = 0;
                int candidateRecipe = 999;

                for (int i = 0; i < _recipeList.RecipeItems.Count; i++)
                {
                    if (_recipeList.RecipeItems[i].Peach != 0 && (int)Setting.Default[_recipeList.RecipeItems[i].Name] == 1)
                    {
                        int addedValueOfTheRecipe = CalculateAddedValue(i);
                        if (addedValue < addedValueOfTheRecipe)
                        {
                            addedValue = addedValueOfTheRecipe;
                            candidateRecipe = i;
                        }
                    }
                }
                return candidateRecipe;
            }

            if (ingredient == IngredientEnum.Cherry)
            {
                int addedValue = 0;
                int candidateRecipe = 999;

                for (int i = 0; i < _recipeList.RecipeItems.Count; i++)
                {
                    if (_recipeList.RecipeItems[i].Cherry != 0 && (int)Setting.Default[_recipeList.RecipeItems[i].Name] == 1)
                    {
                        int addedValueOfTheRecipe = CalculateAddedValue(i);
                        if (addedValue < addedValueOfTheRecipe)
                        {
                            addedValue = addedValueOfTheRecipe;
                            candidateRecipe = i;
                        }
                    }
                }
                return candidateRecipe;
            }

            if (ingredient == IngredientEnum.Coconut)
            {
                int addedValue = 0;
                int candidateRecipe = 999;

                for (int i = 0; i < _recipeList.RecipeItems.Count; i++)
                {
                    if (_recipeList.RecipeItems[i].Coconut != 0 && (int)Setting.Default[_recipeList.RecipeItems[i].Name] == 1)
                    {
                        int addedValueOfTheRecipe = CalculateAddedValue(i);
                        if (addedValue < addedValueOfTheRecipe)
                        {
                            addedValue = addedValueOfTheRecipe;
                            candidateRecipe = i;
                        }
                    }
                }
                return candidateRecipe;
            }

            throw new ArgumentException("Invalid ingredient", nameof(ingredient));
        }

        private int CalculateAddedValue(int number)
        {
            return _recipeList.RecipeItems[number].Flour * _ingredientList.IngredientItems[0].Price
                    + _recipeList.RecipeItems[number].WholeWheatFlour * _ingredientList.IngredientItems[1].Price
                    + _recipeList.RecipeItems[number].Sugar * _ingredientList.IngredientItems[2].Price
                    + _recipeList.RecipeItems[number].BrownSugar * _ingredientList.IngredientItems[3].Price
                    + _recipeList.RecipeItems[number].TomatoPuree * _ingredientList.IngredientItems[4].Price
                    + _recipeList.RecipeItems[number].Potato * _ingredientList.IngredientItems[5].Price
                    + _recipeList.RecipeItems[number].Carrot * _ingredientList.IngredientItems[6].Price
                    + _recipeList.RecipeItems[number].Tomato * _ingredientList.IngredientItems[7].Price
                    + _recipeList.RecipeItems[number].Pumpkin * _ingredientList.IngredientItems[8].Price
                    + _recipeList.RecipeItems[number].Apple * _ingredientList.IngredientItems[9].Price
                    + _recipeList.RecipeItems[number].Orange * _ingredientList.IngredientItems[10].Price
                    + _recipeList.RecipeItems[number].Pear * _ingredientList.IngredientItems[11].Price
                    + _recipeList.RecipeItems[number].Peach * _ingredientList.IngredientItems[12].Price
                    + _recipeList.RecipeItems[number].Cherry * _ingredientList.IngredientItems[13].Price
                    + _recipeList.RecipeItems[number].Coconut * _ingredientList.IngredientItems[14].Price;
        }
    }
}
