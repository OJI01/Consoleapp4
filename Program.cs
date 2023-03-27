using System;

namespace MobilApp
{
    class Mobil
    {
        // Properti mobil
        public string Warna { get; set; }
        public int JumlahPintu { get; set; }
        public string Merek { get; set; }
        public string Model { get; set; }
        public int TahunKeluaran { get; set; }

        // Method mobil
        public void HitungKecepatan(int jarak, int waktu)
        {
            double kecepatan = (double)jarak / waktu;
            Console.WriteLine($"Kecepatan mobil adalah {kecepatan} km/jam\n");
        }

        public void Klakson1()
        {
            Console.WriteLine("bunyi klakson : Tin! Tin!");
            Console.WriteLine("===================================\n");
        }
        public void Klakson2()
        {
            Console.WriteLine("bunyi klakson : beep! beep!");
            Console.WriteLine("===================================\n");
        }
        public void Klakson3()
        {
            Console.WriteLine("bunyi klakson :Trenkkk! Trenkkk!");
            Console.WriteLine("===================================\n");
        }

        public void TampilInfo()
        {
            Console.WriteLine($"Merek Mobil    : {Merek} \n");
            Console.WriteLine($"Dengan model   : {Model} \n");
            Console.WriteLine($"Variasi warna  : {Warna} \n");
            Console.WriteLine($"Jumlah pintu   : {JumlahPintu} pintu\n");
            Console.WriteLine($"Jeluaran tahun : {TahunKeluaran}\n");
        }
    }
}

    
