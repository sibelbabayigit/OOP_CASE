using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class Personel
    {
        public string Ad { get; set; }
        public string Unvan { get; set; }
        public decimal SaatlikUcret { get; set; }

        public virtual decimal MaasHesapla(int calismaSaati)
        {
            return SaatlikUcret * calismaSaati;
        }
        public virtual decimal MesaiHesapla(int calismaSaati)
        {
            return (calismaSaati-180)*SaatlikUcret*1.5M ;
        }
    }
}
