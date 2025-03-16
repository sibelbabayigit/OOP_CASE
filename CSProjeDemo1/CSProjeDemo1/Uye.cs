using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class Uye : IUye
    {
        public string Ad { get ; set ; }
        public string Soyad { get; set; }
        public int UyeNumarasi { get ; set ; }
        public List<Kitap> OduncKitaplar { get ; set ; }

        public Uye()
        {
            OduncKitaplar = new List<Kitap>();
        }

        public void KitapOduncAl(Kitap kitap)
        {
            if (kitap.KitapDurumu == Durum.OduncAlabilir)
            {
                OduncKitaplar.Add(kitap);
                kitap.KitapDurumu = Durum.OduncVerildi;
                Console.WriteLine($"{kitap.Baslik} kitabını ödünç aldınız.");
            }
            else
            {
                Console.WriteLine($"{kitap.Baslik} kitabı şu anda ödünç alınamaz.");
            }
        }

        public void KitapIadeEt(Kitap kitap)
        {
            if (OduncKitaplar.Contains(kitap))
            {
                OduncKitaplar.Remove(kitap);
                kitap.KitapDurumu = Durum.OduncAlabilir;
                Console.WriteLine($"{kitap.Baslik} kitabını başarıyla iade ettiniz.");
            }
            else
            {
                Console.WriteLine($"{kitap.Baslik} kitabını zaten ödünç almamışsınız.");
            }
        }
    }
}
