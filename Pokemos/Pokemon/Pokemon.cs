using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Pokemon
    {
        public int Numero { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string URLImagen { get; set; }

        public Elemento Tipo { get; set; }

        public Elemento Debilidad { get; set; }
    }
}
