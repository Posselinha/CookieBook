public static class CookieBook
{
    private readonly static List<Ingredient> Ingredients = new List<Ingredient>
    {
        new FarinhaTrigo(),
        new FarinhaCoco(),
        new Manteiga(),
        new Chocolate(),
        new Acucar(),
        new Cardamomo(),
        new Canela(),
        new CacauPo()
    };

    public static void ShowAvailableIngredients()
    {
        foreach (Ingredient ingredient in Ingredients)
        {
            Console.WriteLine(ingredient);
        }
    }

    public static Ingredient? FindIngredient(int ingredientId) => Ingredients.Find(x => x.Id == ingredientId);
}
