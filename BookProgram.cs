public static class BookProgram
{
    public static void Start()
    {
        Recipe.ShowAvailableRecipes();
        Console.WriteLine("Crie uma nova receita de cookie! Os ingredients disponiveis são!");
        CookieBook.ShowAvailableIngredients();
        do
        {
            string? userInput = Console.ReadLine();

            bool isInt = int.TryParse(userInput, out int parsedInput);

            if (isInt)
            {
                if (CookieBook.FindIngredient(parsedInput) is not null)
                {
                    Recipe.AddToRecipe(parsedInput);
                }
            }
            else
            {
                if (Recipe.NewCookieRecipe.Count() > 0)
                {
                    Console.WriteLine("Receita Adicionada:");
                    Recipe.ShowRecipe(Recipe.NewCookieRecipe.ToArray());
                    FileHandler.WriteRecipeFile(Recipe.NewCookieRecipe);
                    Console.WriteLine("\nAperte Qualquer botão para sair.");
                    Console.ReadKey();
                    return;
                } else
                {
                    Console.WriteLine("\nNenhum ingrediente foi selecionado! A receita não será salva.");
                    Console.WriteLine("Aperte Qualquer botão para sair.");
                    Console.ReadKey();
                    return;
                }
            }
        } while (true);
    }
}
