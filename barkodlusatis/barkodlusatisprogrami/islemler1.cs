using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elitsoftBarkodluSatis
{
  
       static class islemler1
        {
            public static double DoubleYap(string deger)
            {
                double sonuc;
                double.TryParse(deger, out sonuc);
                return sonuc;
            }

            public static void StokAzalt(string barkod, double miktar)
        {
            if(barkod!="1111111111116")
            {
               using (var db=new BarkodDbEntities1())
            {
                var urunbilgi = db.Urun.SingleOrDefault(x => x.Barkod == barkod);
                urunbilgi.Miktar -= miktar;
                db.SaveChanges();
            }
            }
            
        }
        public static void StokArtir(string barkod, double miktar)
        {
            if (barkod != "1111111111116")
            {
              using (var db = new BarkodDbEntities1())
            {
                var urunbilgi = db.Urun.SingleOrDefault(x => x.Barkod == barkod);
                urunbilgi.Miktar += miktar;
                db.SaveChanges();
            }
            }
                
        }

    }
    }

