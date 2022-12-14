using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotKayitSistemi
{
    internal class Ders
    {
        String yariYil;
        String dersAdi;
        String not;
        String dersKredisi;

        public Ders()
        {

        }

        public Ders(string yariyil,string dersAdi, string not, string dersKredisi)
        {
            this.yariYil = yariyil;
            this.dersAdi = dersAdi;
            this.not = not;
            this.dersKredisi = dersKredisi;
        }

        public String getDersAdi()
        {
            return this.dersAdi;
        }

        public void setDersAdi()
        {
            this.dersAdi = this.not;
        }

        public String getNot()
        {
            return this.not;
        }

        public void setNot(String not)
        {
            this.not = not;
        }

        public void setYariYil(String yariyil)
        {
            this.yariYil = yariyil;
        }

        public String getYariYil()
        {
            return this.yariYil;
        }

        public void setDersKredisi(String dersKredisi)
        {
            this.dersKredisi = dersKredisi;
        }

        public String getDersKredisi()
        {
            return this.dersKredisi;
        }
    }
}
