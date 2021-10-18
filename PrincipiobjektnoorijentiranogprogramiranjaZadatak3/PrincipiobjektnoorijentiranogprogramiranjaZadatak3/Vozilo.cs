using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiobjektnoorijentiranogprogramiranjaZadatak3
{
    class Vozilo
    {
        public bool JeLiLeti;
        public bool JeLiPlovi;

        public void KudaVozi()
        {
            Console.WriteLine("{0} {1}", JeLiLeti, JeLiPlovi);
        }
    }
}
