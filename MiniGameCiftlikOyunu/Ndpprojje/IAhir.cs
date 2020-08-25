using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ndpprojje
{
    //IAhir interfacesinde ahira ait fonksiyonlar tanımlanıyor
    //süt arttır ve sütleri sat fonksiyonları gibi
    public interface IAhir
    {      
        void SutArttir(int _saniye);
        int SutleriSat();
    }
}
