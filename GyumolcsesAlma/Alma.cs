using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyumolcsesAlma
{
    public class Alma : Gyumolcs
    {
        public string fajta;

        public Alma(string nev, string szin, double suly, string fajta) : base(nev, szin, suly)
        {
            this.fajta = fajta;
        }

        public override string ToString()
        {
            return base.ToString() + $", fajtája: {fajta}";
        }
    }
}
