﻿using tpmodul7_kelompok_05;
using static tpmodul7_kelompok_05.KuliahMahasiswa_1302223107;

class Program
{
    static void Main(string[] args)
    {
        Datamahasiswa_1302223107 mhs = new Datamahasiswa_1302223107();

        mhs.ReadJSON();

        Kuliahmahasiswa_1302223107 kuliahMahasiswa = new Kuliahmahasiswa_1302223107();
        kuliahMahasiswa.ReadJson2();

    }
}