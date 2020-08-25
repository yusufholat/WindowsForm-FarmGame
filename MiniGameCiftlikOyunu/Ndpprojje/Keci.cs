using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Ndpprojje
{
    //hayvan sınıfından ve ahir interfacesinden kalıtım alan keci classı
    class Keci : Hayvan,IAhir
    {
        int sutMiktari;
        int sutDegeri;
        public int SutMiktari { get => sutMiktari; }

        public SoundPlayer kecisesi = new SoundPlayer(Properties.Resources.kecisesi);

        //kurucu fonksiyonunda keci için farklı değer alan değişkenler atanıyor
        public Keci()
        {
            sutDegeri = 8;
            enerjiAzalması = 6;
            uretimDongusu = 7;
        }

        //keci kontrol fonksiyonunda keci yaşıyorsa süt arttırılcak
        //yaşamıyorsa ve ses çıkarmadıysa bir sefer ses çalıştırılıyor
        public void KeciKontrol()
        {
            if (yasiyorMu)
            SutArttir(Oyun.saniye);
            else if (!yasiyorMu && !sesCikardiMi)
            {               
                kecisesi.Play();
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
