using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Kerem";
            int yas = 21;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Kerem Yağcı";
            kurs1.İzlenmeoranı = 66;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.Egitmen = "Kerem Yağcı";
            kurs2.İzlenmeoranı = 24;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyhton";
            kurs3.Egitmen = "Ayşe";
            kurs3.İzlenmeoranı = 56;

            Console.WriteLine("Hello World!");
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
            
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+":"+kurs.Egitmen);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeoranı { get; set; }
    }
}
