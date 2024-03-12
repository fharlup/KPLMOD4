using System;

class Fungsi
{
    enum Kelurahan
    {
        Batununggal, Kujangsari, Mengger, Wates,
        Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja
    }

    enum Kode
    {
        Kode1 = 40266,
        Kode2 = 40287,
        Kode3 = 40287,
        Kode4 = 40256,
        Kode5 = 40287,
        Kode6 = 40287,
        Kode7 = 40286,
        Kode8 = 40286,
        Kode9 = 40272,
        Kode10 = 40274,
        Kode11 = 40273
    };

    static void Main(string[] args)
    {
       foreach (Kelurahan kelurahan in Enum.GetValues(typeof(Kelurahan)))
        {
            int pos = (int)Enum.Parse(typeof(Kode), "Kode" + ((int)kelurahan + 1));
            Console.WriteLine($"kelurahan:{kelurahan}kode:{pos}");
        }
    }
}
