using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class KitapRoman:Kitap
    {
        public string AnaKarakter { get; set; }

        public KitapRoman(string isbn, string baslik, string yazar, int yayinYili, string anaKarakter)
        {
            ISBN = isbn;
            Baslik = baslik;
            Yazar = yazar;
            YayinYili = yayinYili;
            KitapDurumu = Durum.MevcutDegil; 
            AnaKarakter = anaKarakter;
        }
    }
}
