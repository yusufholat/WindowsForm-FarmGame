using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ndpprojje
{
    abstract class Hayvan
    {
        int enerji;
        protected bool yasiyorMu;
        protected string yasiyorMuText;
        protected bool sesCikardiMi;
        protected int enerjiAzalması;
        protected int uretimDongusu;
        protected int kazanc;

        public int Enerji { get => enerji; }
        public string YasiyorMuText { get => yasiyorMuText; }
       

        //hayvandan kalıtım alan classın tan üye oluşturulduğunda hayvanın başlaması gereken
        //değerler atanıyor.
        public Hayvan()
        {
            enerji = 100;
            yasiyorMu = true;
            yasiyorMuText = "NEFES ALIYOR";
            sesCikardiMi = false;
        }

        //yemVer fonksiyonu hayvanların enerjisini 100 yapıyor
        public void YemVer()
        {
            if (yasiyorMu)
            enerji = 100;
        }

        
        public void enerjiAzalt()
        {
            //enerji azalma fonksiyonu enerji değeri azalma değerinden düşükse
            //hayvan ölmüş oluyor. Enerjisini sıfırlayıp yaşama durumunu da 
            //değiştiriyoruz
            if (enerji < enerjiAzalması)
            {
                enerji = 0;
                yasiyorMu = false;
                yasiyorMuText = "MEFTA";
            }
            else
                enerji -= enerjiAzalması;
        }


    }
}
