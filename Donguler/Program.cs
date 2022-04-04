using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştici kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "java";

            //array---dizi

            string[] kurslar = new string[] { "yazılım geliştici kampı", "programlamaya başlangıç için temel kurs",
                "java","pyhton","C" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
                //--foreach dizileri tek tek kolay dolaşır daha kolay
            }
            Console.WriteLine("sayfa sonu  - footer");
        }   

    }
}
