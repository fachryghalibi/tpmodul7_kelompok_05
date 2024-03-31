using tpmodul7_kelompok_05;
using static tpmodul7_kelompok_05.KuliahMahasiswa_1302223139;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa_1302223139 mhs = new DataMahasiswa_1302223139();

        mhs.ReadJSON();

        KuliahMahasiswa1302223139 kuliahMahasiswa = new KuliahMahasiswa1302223139();
        kuliahMahasiswa.ReadJson2();
    }
}