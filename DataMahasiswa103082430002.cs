using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace tpmodul7_kelompok_7
{
    internal class DataMahasiswa103082430002
    {
        public string nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }

        public void ReadJSON()
        {
            // Membaca file JSON
            string jsonString = File.ReadAllText("tp7_103082430002.json");

            // Deserialisasi ke object
            DataMahasiswa103082430002 data = JsonSerializer.Deserialize<DataMahasiswa103082430002>(jsonString);

            Console.WriteLine($"Nama {data.nama} dengan nim {data.nim} dari fakultas {data.fakultas}");
        }
    }
}
