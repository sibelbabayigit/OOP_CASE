using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class Yonetici : Personel
    {
        public decimal Bonus { get { return 100; } }

        public override decimal MaasHesapla(int calismaSaati)
        {
            return base.MaasHesapla(calismaSaati) + Bonus;
        }

        public override decimal MesaiHesapla(int calismaSaati)
        {
            return 0;
        }
    }
}
