using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotKayitSistemi
{
    internal class Ogrenciler
    {
         public static List<Ogrenci> ogrenciler = new List<Ogrenci>();
        static int id = 0;
        public static void ogrenciEkle(Ogrenci ogrenci)
        {
            ogrenci.setId(id++);
            ogrenciler.Add(ogrenci);
        }
    }
}
