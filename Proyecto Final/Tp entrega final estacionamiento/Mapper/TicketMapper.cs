using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class TicketMapper
    {

        public static Ticket MapTicket(SqlDataReader reader, Usuario usuario, Estacionamiento estacionamiento)
        {
            Ticket tkt = new Ticket();
            try
            {
                tkt.TicketId = Convert.ToInt32(reader["ID_TICKET"].ToString());
                tkt.UsuarioId = usuario;
                tkt.EstacionamientoId = estacionamiento;
                tkt.FechaEntrada = Convert.ToDateTime(reader["FECHA_ENTRADA"].ToString());
                tkt.FechaSalida = Convert.ToDateTime(reader["FECHA_SALIDA"].ToString());
                tkt.Precio = Convert.ToDouble(reader["PRECIO"].ToString());

                return tkt;
            }
            catch (Exception ex)
            {

                throw;
            }

        }

    }
}
