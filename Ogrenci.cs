using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotKayitSistemi
{
    class Ogrenci
    {
        int id;
        String numara;
        String adiSoyadi;
        List<Ders> dersList;

        
        public Ogrenci(string numara, string adiSoyadi)
        {
            this.numara = numara;
            this.adiSoyadi = adiSoyadi;
            this.dersList = new List<Ders>();
        }

        public Ogrenci()
        {
            this.dersList = new List<Ders>();
        }

        public String getNumara()
        {
            return numara;
        }

        public String getAdiSoyadi()
        {
            return adiSoyadi;
        }

        public void setNumara(String numara)
        {
            this.numara = numara;
        }

        public void setAdiSoyadi(String adiSoyadi)
        {
            this.adiSoyadi = adiSoyadi;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public List<Ders> getDersList()
        {
            return dersList;
        }

        public void setDersList(List<Ders> dersList)
        {
            this.dersList = dersList;
        }

    }
}
