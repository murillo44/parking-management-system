using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class TicketBusiness
    {

        private TicketDAO ticketDAO = new TicketDAO();
        private EstacionamientoDAO estacionamientoDAO = new EstacionamientoDAO();

        public void ModificarTicket(int idTicket,int idEstacionamiento,int idUsuario)
        {          
            try
            {
                Ticket ticketEncontrado = new Ticket();
                
                ticketEncontrado = ticketDAO.ObtenerTicketPorID(idTicket);
                if (idEstacionamiento != ticketEncontrado.EstacionamientoId.EstacionamientoId)
                {
                    throw new Exception("El estacionamiento no coincide con el numero de ticket");
                }                
                if(idUsuario != ticketEncontrado.UsuarioId.UsuarioId) 
                {
                    throw new Exception("El usuario no coincide con el numero de ticket");
                }
                if (ticketEncontrado.FechaEntrada != ticketEncontrado.FechaSalida)
                {
                    throw new Exception("El auto ya fue retirado y el ticket es invalido");
                }
                
                ticketDAO.ModificarTicket(idTicket);

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
        public double CalcularCostos(int idTicket)
        {
            try
            {
                Ticket ticketEncontrado = new Ticket();
                ticketEncontrado = ticketDAO.ObtenerTicketPorID(idTicket);
                TimeSpan diferencia = ticketEncontrado.FechaSalida - ticketEncontrado.FechaEntrada;
                double minutes = diferencia.TotalMinutes;
                double costo = minutes * 60;
                ticketDAO.ModificarPrecio(ticketEncontrado,costo);
                return costo;


            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public List<Ticket> ObtenerTickets()
        {
            List<Ticket> Ltickets = new List<Ticket>();
            try
            {
                return ticketDAO.ObtenerTicketsDAO();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<object> MostrarTicketsDB(List<Ticket> ListarTickets)
        {
            List<object> TicketsEnBase = new List<object>();

            // Iteramos sobre cada aplicación
            foreach (var ticket in ListarTickets)
            {
                var tkt = new
                {
                    TicketId = ticket.TicketId,
                    UsuarioId = ticket.UsuarioId.Email,
                    EstacionamientoId = ticket.EstacionamientoId.Nombre,
                    FechaEntrada = ticket.FechaEntrada,
                    FechaSalida = ticket.FechaSalida,
                    Precio = ticket.Precio,
                };

                // Añadimos el objeto anónimo a la lista
                TicketsEnBase.Add(tkt);
            }

            return TicketsEnBase;
        }

        public void AltaTicket(Ticket ticket,Estacionamiento estacionamiento)
        {
            try
            {

                Estacionamiento estacionamientoEncontrado = new Estacionamiento();
                estacionamientoEncontrado = estacionamientoDAO.BuscarEstacionamientoPorID(estacionamiento.EstacionamientoId);
                List<Ticket> LTicket = new List<Ticket>();
                LTicket = ticketDAO.ObtenerTicketsDAO();

                using (var trx = new TransactionScope())
                {
                    foreach (var ticketbuscado in LTicket)
                    {
                        if (ticketbuscado.UsuarioId.UsuarioId == ticket.UsuarioId.UsuarioId)
                        {
                            throw new Exception("El usuario solo puede generar un ticket por estacionamiento");
                        }
                    }

                    if (estacionamientoEncontrado.Capacidad <= estacionamientoEncontrado.Ocupados)
                    {
                        throw new Exception("No hay mas capacidad en este estacionamiento");
                    }               
                    ticket.FechaEntrada = DateTime.Now;
                    ticket.FechaSalida = DateTime.Now;
                    ticket.Precio = 0;
                    ticketDAO.AltaTicket(ticket,estacionamiento);
                    trx.Complete();
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }



    }
}
