using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDinamica.Negocios
{
    public class Beca
    {
        public Boolean OtorgarBeca(int prom)
        {
            return (prom > 98) ? true : false;

        }
    }
}
