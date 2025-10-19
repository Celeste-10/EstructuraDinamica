using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDinamica.Modelos
{
    /// <summary>
    /// Expediente del estudiante
    /// </summary>
    public class Expediente
    {
        public int NumExp { set; get; }
        public string Nombres { set; get; }
        public string Apellidos { set; get; }

        public int Promedio { set; get; }
    }
}
