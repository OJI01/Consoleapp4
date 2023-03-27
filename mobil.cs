using MobilApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class mobil
    {
        class Program
        {
            static void Main(string[] args)
            {
                Mobil mobil1 = new Mobil();
                
                // Set properti mobil
                mobil1.Warna = "Putih";
                mobil1.JumlahPintu = 2;
                mobil1.Merek = "lamborgini";
                mobil1.Model = "Veneno Roadster";
                mobil1.TahunKeluaran = 2013;

                // Panggil method mobil
                mobil1.TampilInfo();
                mobil1.Klakson1();
                mobil1.HitungKecepatan(710, 2);

                Mobil mobil2 = new Mobil();

                // Set properti mobil
                mobil2.Warna = "Hitam";
                mobil2.JumlahPintu = 2;
                mobil2.Merek = "Bugatti";
                mobil2.Model = "Chiron";
                mobil2.TahunKeluaran = 2018;

                // Panggil method mobil
                mobil2.TampilInfo();
                mobil2.Klakson2();
                mobil2.HitungKecepatan(620, 2);

                Mobil mobil3 = new Mobil();

                // Set properti mobil
                mobil3.Warna = "Merah";
                mobil3.JumlahPintu = 2; 
                mobil3.Merek = "Ferari";
                mobil3.Model = "J50";
                mobil3.TahunKeluaran = 2016;

                // Panggil method mobil
                mobil3.TampilInfo();
                mobil3.Klakson3();
                mobil3.HitungKecepatan(1028, 2);

                Console.ReadKey();
            }
        }
    }
}

