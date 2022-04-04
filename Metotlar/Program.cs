using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elma";
            double fiyati = 15;
            string aciklama = "Amasyadan elma";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 24;
            urun1.Aciklama = "Amasya elması";
            urun1.StokAdedi = 3591;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 33;
            urun2.Aciklama = "Çekirdeksiz Karpuz";
            urun2.StokAdedi = 673;

            Urun[] urunler = new Urun[] {urun1,urun2, };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("----------------Metotlar----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);   
            
            sepetManager.Ekle2("Armut","yeşil",12);
        }
    }
}





//Dont repeat yourself--DRY--CLEAN CODE--BEST PRACTİCE