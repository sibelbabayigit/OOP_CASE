using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class DosyaOku
    {
        public List<Personel> PersonelListesiOku(string dosyaYolu)
        {
            string json = File.ReadAllText(dosyaYolu);


            List<Personel> personeller = JsonConvert.DeserializeObject<List<Personel>>(json);

            return personeller;
        }
    }
}
