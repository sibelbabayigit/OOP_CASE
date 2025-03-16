using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class Memur : Personel
    {

        public int Derece { get; set; }

        public override decimal MaasHesapla(int calismaSaati)
        {
            if (calismaSaati > 180)
            {
                

                decimal anaMaas = base.SaatlikUcret * 180;

                return anaMaas + (Derece * 100);
            }
            else
            {
                return base.SaatlikUcret * calismaSaati + (Derece * 100);
            }

        }

        public override decimal MesaiHesapla(int calismaSaati)
        {
            int ekMesaiSaat = calismaSaati - 180;
            if (ekMesaiSaat>0)
                return base.SaatlikUcret * 1.5M * ekMesaiSaat;
            return 0;
        }

    }
}
