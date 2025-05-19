using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Estacionamiento
    {
        public int EstacionamientoId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Capacidad { get; set; }
        public int Ocupados { get; set; }

    }
}
