using System.Text.Json;

public class DataMahasiswa103082400010
{ 
    public string nama { get; set; }
    public string nim { get; set; }
    public string fakultas { get; set; }

    public void ReadJSON()
    {
        // Baca file json
        string jsonString = File.ReadAllText("tp7_1_103082400010.json");

        // Deserialisasi string ke Object
        DataMahasiswa103082400010 data = JsonSerializer.Deserialize<DataMahasiswa103082400010>(jsonString);

        
        Console.WriteLine($"Nama {data.nama} dengan nim {data.nim} dari fakultas {data.fakultas}");
    }
}