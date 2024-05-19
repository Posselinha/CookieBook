public static class Recipe
{
    public static List<int> NewCookieRecipe = new List<int>();
    public static List<int[]> recipesList = FileHandler.ReadRecipeFile();

    public static void AddToRecipe(int ingredientId)
    {
        NewCookieRecipe.Add(ingredientId);
    }

    public static void ShowRecipe(int[] recipe)
    {
        foreach (int ingredientId in recipe)
        {
            Ingredient? ingredient = CookieBook.FindIngredient(ingredientId);
            if (ingredient is not null)
            {
                Console.WriteLine($"{ingredient.Name}. {ingredient.PreparationInstruction()}");
            }
        }

    }

    public static void ShowAvailableRecipes()
    {
        if (recipesList.Count() > 0)
        {

            int recipeIterator = 1;
            Console.WriteLine("Receitas existentes são:\n");
            foreach (int[] recipe in recipesList)
            {
                Console.WriteLine($"***** {recipeIterator} *****");
                Recipe.ShowRecipe(recipe);
                recipeIterator++;
                Console.WriteLine();
            }
        }
    }
}
