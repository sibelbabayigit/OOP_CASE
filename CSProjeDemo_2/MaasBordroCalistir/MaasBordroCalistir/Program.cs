using CSProjeDemo2;

namespace MaasBordroCalistir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DosyaOku dosyaOku = new DosyaOku();
            MaasBordro maasBordro = new MaasBordro();

            List<Personel> personeller = dosyaOku.PersonelListesiOku("personeller.json");
            foreach (var p in personeller)
            {
                if(p.Unvan=="Yonetici")
                {
                    Yonetici yonetici = new Yonetici()
                    {
                        Ad = p.Ad,
                        Unvan = p.Unvan,
                    };

                    Console.Write($"{yonetici.Ad} Calisma Saati: ");
                    int calismaSaati = Convert.ToInt32(Console.ReadLine());

                    Console.Write($"{yonetici.Ad} Saatlik Ücreti: ");
                    yonetici.SaatlikUcret = Convert.ToInt32(Console.ReadLine());
                    while (yonetici.SaatlikUcret < 500)
                    {
                        Console.WriteLine("Yoneticilerin saatlik ücreti 500'den küçük olamaz");
                        Console.Write($"{yonetici.Ad} Saatlik Ücreti: ");
                        yonetici.SaatlikUcret = Convert.ToInt32(Console.ReadLine());
                    }
                    maasBordro.BordroOlustur(yonetici, calismaSaati);
                }
                else
                {
                    Memur memur = new Memur()
                    {
                        Ad = p.Ad,
                        Unvan = p.Unvan,
                    };

                    Console.Write($"{memur.Ad} Calisma Saati: ");
                    int calismaSaati = Convert.ToInt32(Console.ReadLine());

                    Console.Write($"{memur.Ad} Saatlik Ücreti: ");
                    memur.SaatlikUcret = Convert.ToInt32(Console.ReadLine());

                    maasBordro.BordroOlustur(memur, calismaSaati);
                }
            }
        }
    }
}
