using System.Text.Json;

public class Course
{
    public string code { get; set; }
    public string name { get; set; }
}

public class KuliahMahasiswa1301210000
{
    public List<Course> courses { get; set; }

    public void ReadJSON()
    {
        string jsonString = File.ReadAllText("tp7_2_1301210000.json");
        KuliahMahasiswa1301210000 data = JsonSerializer.Deserialize<KuliahMahasiswa1301210000>(jsonString);

        Console.WriteLine("Daftar mata kuliah yang diambil:");
        for (int i = 0; i < data.courses.Count; i++)
        {
            // Output sesuai format [cite: 60, 61, 62]
            Console.WriteLine($"MK {i + 1} {data.courses[i].code} - {data.courses[i].name}");
        }
    }
}