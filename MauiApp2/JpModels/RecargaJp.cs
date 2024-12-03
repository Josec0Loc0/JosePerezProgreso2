using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progreso2JosePerez.JpModels
{
    public class RecargaJp
    {
        public string Nombre { get; set; }
        public string Numero { get; set; }

        public override string ToString()
        {
            return $"Nombre:{Nombre},Telefono:{Numero}";

        }
    }
}
