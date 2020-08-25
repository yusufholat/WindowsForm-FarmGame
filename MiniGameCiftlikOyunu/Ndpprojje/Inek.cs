using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Ndpprojje
{
    //hayvan sınıfından ve ahir interfacesinden kalıtım alan inek sınıfı
    class Inek : Hayvan,IAhir
    {
        int sutMiktari;
        int sutDegeri;
        public int SutMiktari { get => sutMiktari; }

        public SoundPlayer ineksesi = new SoundPlayer(Properties.Resources.ineksesi);

        //kurucu fonksiyonunda inek için farklı değer alan değişkenler atanıyor
        public Inek()
        {
            sutDegeri = 5;
            enerjiAzalması = 8;
            uretimDongusu = 8;
        }

        //inek kontrol fonksiyonunda inek yaşamıyorsa süt arttırılcak
        //yaşamıyorsa ve ses çıkarmadıysa bir sefer ses çalıştırılıyor
        public void InekKontrol()
        {
            if (yasiyorMu)
            SutArttir(Oyun.saniye);
            else if (!yasiyorMu && !sesCikardiMi)
            {               
                ineksesi.Play();
                sesCikardiMi = true;
            }
        }

        //interface tarafından alınan fonksiyonların tanımlandığı kısım
        #region IAhir Üyeleri
        public void SutArttir(int _saniye)
        {
            //oyunun saniyesine göre üretim döngüsü yapılıyor
            if (_saniye % uretimDongusu == 0)
                sutMiktari++;
        }
        public int SutleriSat()
        {
            kazanc = sutDegeri * sutMiktari;
            sutMiktari = 0;
            return kazanc;
        }
        #endregion

    }
}
