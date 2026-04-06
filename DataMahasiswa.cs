using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace tpmodul7_kelompok_7
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public class DataMahasiswa
    {
        public Nama nama { get; set; }
        public string nim { get; set; }
        public string fakultas { get; set; }

        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("tp7_1_103082400012.json");
            DataMahasiswa data = JsonSerializer.Deserialize<DataMahasiswa>(jsonString);

            Console.WriteLine("Nama " + data.nama.depan + " " + data.nama.belakang +
                              " dengan nim " + data.nim +
                              " dari fakultas " + data.fakultas);

        }
    }
}
