using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyumolcsesAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Gyumolcs> gyumolcsok = new List<Gyumolcs>();
            gyumolcsok.Add(new Gyumolcs("banán","sárga",200));
            gyumolcsok.Add(new Alma("alma", "zöld", 350, "Gala"));
            gyumolcsok.Add(new Gyumolcs("sárkánygyülmöcs", "lila", 300));
            gyumolcsok.Add(new Alma("alma", "sárga", 100, "Jonagold"));



            int alma = 0;
            int nemAlma = 0;

            foreach (var gyumolcs in gyumolcsok)
            {
                if (gyumolcs is Alma)
                    alma++;
                else
                    nemAlma++;
            }


            Console.WriteLine($"A listában {alma} db alma van és {nemAlma} db nem alma.");
        }
    }
}
