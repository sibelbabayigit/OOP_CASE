using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class KitapBilim:Kitap
    {
        public string KonuAlanı { get; set; }

        public KitapBilim(string isbn, string baslik, string yazar, int yayinYili, string konuAlanı)
        {
            ISBN = isbn;
            Baslik = baslik;
            Yazar = yazar;
            YayinYili = yayinYili;
            KitapDurumu = Durum.MevcutDegil;
            KonuAlanı = konuAlanı;
        }
    }
}
