using tpmodul7_kelompok_05;
using static tpmodul7_kelompok_05.KuliahMahasiswa_1302223095;

class Program
{
    static void Main(string[] args)
    {
        Datamahasiswa_1302223095 mhs = new Datamahasiswa_1302223095();

        mhs.ReadJSON();

        KuliahMahasiswa1302223095 kuliahMahasiswa = new KuliahMahasiswa1302223095();
        kuliahMahasiswa.ReadJson2();

    }
}