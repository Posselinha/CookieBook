using System.Text.Json;

public static class FileHandler
{
    const string FileName = "recipes.json";

    public static void WriteRecipeFile(List<int> recipeList)
    {
        if (File.Exists(FileName))
        {
            List<int[]> recipeFileContent = FileHandler.ReadRecipeFile();
            recipeFileContent.Add(recipeList.ToArray());
            string jsonData = JsonSerializer.Serialize(recipeFileContent);

            File.WriteAllText(FileName, jsonData);
        }
        else
        {
            List<int[]> data = [recipeList.ToArray()];
            string jsonData = JsonSerializer.Serialize(data);
            File.WriteAllText(FileName, jsonData);
        }

    }

    public static List<int[]> ReadRecipeFile()
    {

        if (File.Exists(FileName))
        {
            string jsonFile = File.ReadAllText("recipes.json");
            List<int[]> jsonData = JsonSerializer.Deserialize<List<int[]>>(jsonFile);
            return jsonData;
        }
        else
        {
            return new List<int[]>();
        }
    }
}