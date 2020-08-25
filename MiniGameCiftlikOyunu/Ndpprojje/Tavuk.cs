using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Ndpprojje
{
    //hayvan sınıfından ve kumes interfacesinden kalıtım alan tavuk sınıfı
    class Tavuk : Hayvan, IKumes
    {
        int yumurtaSayisi;
        int yumurtaDegeri;
        public int YumurtaSayisi { get => yumurtaSayisi; }

        public SoundPlayer tavuksesi = new SoundPlayer(Properties.Resources.tavuksesi);

        //kurucu fonksiyonunda tavuk için farklı değer alan değişkenler atanıyor
        public Tavuk()
        {
            yumurtaDegeri = 1;
            enerjiAzalması = 2;
            uretimDongusu = 3;
            yumurtaSayisi = 0;
        }

        //tavuk kontrol fonksiyonunda tavuk yaşıyorsa yumurta arttırılcak
        //yaşamıyorsa ve ses çıkarmadıysa bir sefer ses çalıştırılıyor
        public void TavukKontrol()
        {
            if (yasiyorMu)
                YumurtaArttir(Oyun.saniye);
            else if (!yasiyorMu && !sesCikardiMi)
            {
                tavuksesi.Play();
                sesCikardiMi = true;
            }
        }

        //interface tarafından alınan fonksiyonların tanımlandığı kısım
        #region IKumes Üyeleri       
        public void YumurtaArttir(int _saniye)
        {
            //oyunun saniyesine göre üretim döngüsü yapılıyor
            if (_saniye % uretimDongusu == 0)
                yumurtaSayisi++;
        }
        public int YumurtalariSat()
        {
            kazanc = yumurtaDegeri * yumurtaSayisi;
            yumurtaSayisi = 0;
            return kazanc;
        }
        #endregion

    }
}
