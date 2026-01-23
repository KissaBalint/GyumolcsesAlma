using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyumolcsesAlma
{
    public class Gyumolcs
    {
        public string nev;
        public string szin;
        public double suly;

        public Gyumolcs(string nev, string szin, double suly)
        {
            this.nev = nev;
            this.szin = szin;
            this.suly = suly;
        }

        public override string ToString()
        {
            return $"A gyümölcs neve: {nev}, színe: {szin}, súlya: {suly}g";
        }
    }
}
