using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_05
{
    internal class Datamahasiswa_1302223107
    {
        public class Nama
        {
            public String depan { get; set; }
            public String belakang { get; set; }
        }
        public Nama nama { get; set; }
        public int nim { get; set; }
        public String fakultas { get; set; }

        public void ReadJSON()
        {
            string filePath = "D:\\Fachry\\Kuliah\\Praktikum KPL\\tpmodul7_kelompok_05\\tpmodul7_kelompok_05\\tp7_1_1302223107.json";

            string jsonText = File.ReadAllText(filePath);

            Datamahasiswa_1302223107 dataMahasiswa = JsonSerializer.Deserialize<Datamahasiswa_1302223107>(jsonText);

            Console.WriteLine($"Nama {dataMahasiswa.nama.depan} {dataMahasiswa.nama.belakang} dengan NIM {dataMahasiswa.nim} dari Fakultas {dataMahasiswa.fakultas}");
        }

    }
}
