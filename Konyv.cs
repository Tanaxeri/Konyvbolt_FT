using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvbolt_FT
{
    internal class Konyv
    {

        public int konyv_id;
        public string konyv_szerzo;
        public string konyv_cim;
        public int konyv_megjelenesiev;
        public string konyv_megjeleneshelye;
        public string konyv_kiado;
        public string konyv_kategoria;
        public string konyv_nyelv;
        public string konyv_sorozatcim;
        public string konyv_isbn;
        public int konyv_ar;

        public Konyv(int konyv_id, string konyv_szerzo, string konyv_cim, int konyv_megjelenesiev, string konyv_megjeleneshelye, string konyv_kiado, string konyv_kategoria, string konyv_nyelv, string konyv_sorozatcim, string konyv_isbn, int konyv_ar)
        {
            this.konyv_id = konyv_id;
            this.konyv_szerzo = konyv_szerzo;
            this.konyv_cim = konyv_cim;
            this.konyv_megjelenesiev = konyv_megjelenesiev;
            this.konyv_megjeleneshelye = konyv_megjeleneshelye;
            this.konyv_kiado = konyv_kiado;
            this.konyv_kategoria = konyv_kategoria;
            this.konyv_nyelv = konyv_nyelv;
            this.konyv_sorozatcim = konyv_sorozatcim;
            this.konyv_isbn = konyv_isbn;
            this.konyv_ar = konyv_ar;
        }

        public override string ToString()
        {
            return konyv_cim + konyv_ar + "Ft";
        }

    }
}
