using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvbolt_FT
{
    internal class Vasarlo
    {

        public int vasarlo_id;
        public string vasarlo_nev;
        public DateTime vasarlo_szuldatum;
        public string vasarlo_email;
        public string vasarlo_felhasznalonev;

        public Vasarlo(int vasarlo_id, string vasarlo_nev, DateTime vasarlo_szuldatum, string vasarlo_email, string vasarlo_felhasznalonev)
        {
            this.vasarlo_id = vasarlo_id;
            this.vasarlo_nev = vasarlo_nev;
            this.vasarlo_szuldatum = vasarlo_szuldatum;
            this.vasarlo_email = vasarlo_email;
            this.vasarlo_felhasznalonev = vasarlo_felhasznalonev;
        }

        public override string ToString()
        {
            return vasarlo_nev;
        }

    }
}
