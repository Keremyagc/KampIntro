using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety--tip güvenliği
            //Do not repeat yourself--Kendini tekrarlama
            //değer tutucu,alias
            
            string kategoriEtiketi = "Kategorilerrr";
            int ogrenciSayisi = 32000;
            Double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 24.64;
            double dolarBugun = 22.56;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("AZALIŞ BUTONU GÖSTER");
            }

            
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("ARTIŞ OKU GÖSTER");
            }

            else
            {
                Console.WriteLine("DOLAR AYNI");
            }


            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Hoşgeldiniz");
            }
            else
            {
                Console.WriteLine("sistemegirişyapınız");
            }
          
            Console.WriteLine(kategoriEtiketi);




        }
    }
}
