using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ndpprojje
{
    //IKumes interfacesinde ahira ait fonksiyonlar tanımlanıyor
    //yumurta arttır ve yumurta sat fonksiyonları gibi
    interface IKumes
    {
        void YumurtaArttir(int _saniye);
        int YumurtalariSat();
    }
}
