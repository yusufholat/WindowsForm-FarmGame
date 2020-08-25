using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ndpprojje
{
    //oyun classı oyunun genel işleyişini sürükleyen fonksiyonlar barındırıyor
    static class Oyun
    {
        public static int saniye = 0;
        public static int toplamKazanc = 0;

        //oyun sürükle fonksiyonu aldığı nesnelerin enerji değerlerini ve kontrol
        //işlerini yapıyor
        public static void OyunuSurukle(Tavuk t, Ordek o, Inek i, Keci k)
        {
            t.enerjiAzalt();
            o.enerjiAzalt();
            i.enerjiAzalt();
            k.enerjiAzalt();

            t.TavukKontrol();
            o.OrdekKontrol();
            i.InekKontrol();
            k.KeciKontrol();
        }
    }
}
