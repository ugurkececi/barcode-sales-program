using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elitsoftBarkodluSatis
{
   static class islemler
    {
        public static double DoubleYap(string deger)
        {
            double sonuc;
            double.TryParse(deger,out sonuc);
            return Math.Round(sonuc,2);
        }
    }
}
