using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public Usuario UsuarioId { get; set; }
        public Estacionamiento EstacionamientoId { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set ; }
        public double Precio { get; set; }
    }
}
