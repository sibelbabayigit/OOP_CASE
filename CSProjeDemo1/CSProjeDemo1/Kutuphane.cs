using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class Kutuphane
    {
        private List<Kitap> Kitaplar { get; set; }
        private List<IUye> Uyeler { get; set; }

        public Kutuphane()
        {
            Kitaplar = new List<Kitap>();
            Uyeler = new List<IUye>();
        }

        public void KitapDurumunuGuncelle(Kitap kitap, Durum durum)
        {
            kitap.KitapDurumu = durum;
        }

        public void UyeEkle(IUye uye)
        {
            Uyeler.Add(uye);
        }

        public void KitapEkle(Kitap kitap)
        {
            Kitaplar.Add(kitap);
        }

    }
}
