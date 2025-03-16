using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class MaasBordro
    {
        public void BordroOlustur(Personel personel, int calismaSaati)
        {
            decimal maas = personel.MaasHesapla(calismaSaati);
            decimal mesai = personel.MesaiHesapla(calismaSaati);
            string dosyaAdi = $"bordrolar/{personel.Ad}_MaasBordro_{DateTime.Now.ToString("MMMM_yyyy")}.json";
            string dosyaIcerik = JsonConvert.SerializeObject(new
            {
                PersonelIsmi = personel.Ad,
                CalismaSaati = calismaSaati,
                AnaOdeme = maas,
                Mesai = mesai,
                ToplamOdeme = maas+mesai
            }, Formatting.Indented);
            RaporGoruntule(dosyaIcerik,calismaSaati);
            File.WriteAllText(dosyaAdi, dosyaIcerik);
        }

        public void RaporGoruntule(string rapor,int calismaSaati)
        {
            Console.WriteLine("Maaş Raporu:");
            if (calismaSaati < 150)
            {
                Console.WriteLine("Bu Personel 150 saatten az çalışmıştır!");
            }
            Console.WriteLine(rapor);
        }
    }
}
