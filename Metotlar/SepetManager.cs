using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //naming convetion-isimlendirme
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Başarı ile Sepete eklendi : " + urun.Adi + urun.Fiyati);
        }
        
        
        public void Ekle2(string urunAdi, string Aciklama,double Fiyat)
        {

        }
    }
}
