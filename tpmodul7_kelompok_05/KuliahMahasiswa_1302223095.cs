using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_05
{
    internal class KuliahMahasiswa_1302223095
    {
        internal class MataKuliah
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        internal class KuliahMahasiswa1302223095
        {
            public List<MataKuliah> courses { get; set; }

            public void ReadJson2()
            {
                string filePath = "C:\\Users\\fadla\\codingan\\SEM 4\\KPL\\tpmodul7_kelompok_5\\tpmodul7_kelompok_05\\tpmodul7_kelompok_05\\tp7_2_1302223095.json";
                string jsonContent = File.ReadAllText(filePath);
                var kuliahMahasiswa = JsonSerializer.Deserialize<KuliahMahasiswa1302223095>(jsonContent);


                Console.WriteLine("Daftar mata kuliah yang diambil:");
                foreach (var course in kuliahMahasiswa.courses)
                {
                    Console.WriteLine($"MK {course.code} - {course.name}");
                }
            }
        }

    }
}