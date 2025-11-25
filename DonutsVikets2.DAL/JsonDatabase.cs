using System.Text.Json;

namespace DonutsVikets.DAL
{


    public static class jsonDatabase
    {
        private static readonly string DataFolder = Path.Combine(Environment.CurrentDirectory, "Data");

        static jsonDatabase()
        {
            if (!Directory.Exists(DataFolder))
            {
                Directory.CreateDirectory(DataFolder);
            }
        }
        public static List<T> Ler<T>(string fileName) where T : class
        {
            string path = Path.Combine(DataFolder, fileName);

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "[]");  

            }
            string json = File.ReadAllText(path);

            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }
        public static void salvar<T>(string fileName, List<T> lista) where T : class
        {
            string path = Path.Combine(DataFolder, fileName);
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(path, json);

        }


    }
}
