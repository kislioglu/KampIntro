using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // Manager,Service,Dal gibi ifadeler varsa bunlar operasyon tutuyor demektir.

        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi:"+ urun.Adi);

        }
    }
}
