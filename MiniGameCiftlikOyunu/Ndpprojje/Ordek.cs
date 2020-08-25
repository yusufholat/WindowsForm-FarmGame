using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Ndpprojje
{
    class Ordek : Hayvan,IKumes
    {
        int yumurtaSayisi;
        int yumurtaDegeri;
        public int YumurtaSayisi { get => yumurtaSayisi; }


        public SoundPlayer ordeksesi = new SoundPlayer(Properties.Resources.ordeksesi);

        //kurucu fonksiyonunda ordek için farklı değer alan değişkenler atanıyor
        public Ordek()
        {
            yumurtaDegeri = 3;
            enerjiAzalması = 3;
            uretimDongusu = 5;
        }

        //ordek kontrol fonksiyonunda ordek yaşıyorsa yumurta arttırılcak
        //yaşamıyorsa ve ses çıkarmadıysa bir sefer ses çalıştırılıyor
        public void OrdekKontrol()
        {
            if (yasiyorMu)
            YumurtaArttir(Oyun.saniye);
            else if (!yasiyorMu && !sesCikardiMi)
            {              
                ordeksesi.Play();
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
