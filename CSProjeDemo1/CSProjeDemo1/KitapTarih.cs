using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class KitapTarih:Kitap
    {
        public string Donem { get; set; }
        public KitapTarih(string isbn, string baslik, string yazar, int yayinYili, string donem)
        {
            ISBN = isbn;
            Baslik = baslik;
            Yazar = yazar;
            YayinYili = yayinYili;
            KitapDurumu = Durum.MevcutDegil; 
            Donem = donem;
        }

    }
}
