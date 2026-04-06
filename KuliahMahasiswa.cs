using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace tpmodul7_kelompok_7
{
    public class MataKuliah
    {
        public string kode_mata_kuliah { get; set; }
        public string nama_mata_kuliah { get; set; }
    }

    public class KuliahMahasiswa
    {
        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("tp7_2_103082400012.json");
            List<MataKuliah> daftarMataKuliah = JsonSerializer.Deserialize<List<MataKuliah>>(jsonString);

            Console.WriteLine("Daftar mata kuliah yang diambil:");

            for (int i = 0; i < daftarMataKuliah.Count; i++)
            {
                Console.WriteLine("MK " + (i + 1) + " " +
                                  daftarMataKuliah[i].kode_mata_kuliah + " - " +
                                  daftarMataKuliah[i].nama_mata_kuliah);
            }
        }
    }
}
