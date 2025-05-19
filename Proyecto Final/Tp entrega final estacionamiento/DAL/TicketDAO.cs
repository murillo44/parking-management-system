using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TicketDAO
    {
        EstacionamientoDAO estacionamientoDAO = new EstacionamientoDAO();
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        public void AltaTicket(Ticket ticket,Estacionamiento Estacionamiento)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString);

                using (conexion)
                {
                    conexion.Open();
                    string queryAltaTicket = "INSERT INTO TICKET (ID_USUARIO, ID_ESTACIONAMIENTO, FECHA_ENTRADA, FECHA_SALIDA,PRECIO) VALUES (@ID_USUARIO, @ID_ESTACIONAMIENTO, @FECHA_INGRESO, @FECHA_SALIDA,@PRECIO);";
                    string querySumarEstacionamiento = "UPDATE ESTACIONAMIENTO SET Ocupados = Ocupados + 1 WHERE ID_ESTACIONAMIENTO = @ID_ESTACIONAMIENTO";
                    using (SqlCommand command = new SqlCommand(queryAltaTicket, conexion))
                    {
                        command.Parameters.AddWithValue("@ID_USUARIO", ticket.UsuarioId.UsuarioId);
                        command.Parameters.AddWithValue("@ID_ESTACIONAMIENTO", ticket.EstacionamientoId.EstacionamientoId);
                        command.Parameters.AddWithValue("@FECHA_INGRESO", ticket.FechaEntrada);
                        command.Parameters.AddWithValue("@FECHA_SALIDA", ticket.FechaSalida);
                        command.Parameters.AddWithValue("@PRECIO", ticket.Precio);
                        command.ExecuteNonQuery();
                    }
                    using (SqlCommand command2 = new SqlCommand(querySumarEstacionamiento, conexion))
                    {                   
                            command2.Parameters.AddWithValue("@ID_ESTACIONAMIENTO", ticket.EstacionamientoId.EstacionamientoId);
                            command2.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Ticket ObtenerTicketPorID(int IDTicket)
        {
            Ticket ticket = new Ticket();
            try
            {
                SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString);
                using (conexion)
                {
                    conexion.Open();
                    string queryBuscarTicketPorID = "SELECT ID_TICKET,ID_USUARIO,ID_ESTACIONAMIENTO,FECHA_ENTRADA,FECHA_SALIDA,PRECIO FROM TICKET WHERE ID_TICKET = @ID_TICKET";
                    using (SqlCommand command = new SqlCommand(queryBuscarTicketPorID, conexion))
                    {
                        command.Parameters.AddWithValue("@ID_TICKET", IDTicket);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Usuario user = new Usuario();
                                Estacionamiento est = new Estacionamiento();
                                user = usuarioDAO.BuscarUsuariosPorID(Convert.ToInt32(reader["ID_USUARIO"].ToString()));
                                est = estacionamientoDAO.BuscarEstacionamientoPorID(Convert.ToInt32(reader["ID_ESTACIONAMIENTO"].ToString()));
                                ticket = TicketMapper.MapTicket(reader,user,est);
                            }
                        }
                    }
                }

                return ticket;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public List<Ticket> ObtenerTicketsDAO()
        {
            List<Ticket> LTicket = new List<Ticket>();
            try
            {
                SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString);
                using (conexion)
                {
                    conexion.Open();
                    string queryBuscarTicket = "SELECT ID_TICKET,ID_USUARIO,ID_ESTACIONAMIENTO,FECHA_ENTRADA,FECHA_SALIDA,PRECIO FROM TICKET";
                    using (SqlCommand command = new SqlCommand(queryBuscarTicket, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Ticket tkt = new Ticket();
                                Usuario user = new Usuario();
                                Estacionamiento est = new Estacionamiento();

                                user = usuarioDAO.BuscarUsuariosPorID(Convert.ToInt32(reader["ID_USUARIO"].ToString()));
                                est = estacionamientoDAO.BuscarEstacionamientoPorID(Convert.ToInt32(reader["ID_ESTACIONAMIENTO"].ToString()));
                                tkt = TicketMapper.MapTicket(reader,user,est);
                                LTicket.Add(tkt);
                            }
                        }
                    }
                }
                return LTicket;
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public void ModificarTicket(int idTicket)
        {

            try
            {
                SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString);

                using (conexion)
                {
                    conexion.Open();
                    string queryEliminarTicket = "UPDATE TICKET SET FECHA_SALIDA = GETDATE() WHERE ID_TICKET = @ID_TICKET; ";
                    

                    using (SqlCommand command = new SqlCommand(queryEliminarTicket, conexion))
                    {
                        command.Parameters.AddWithValue("@ID_TICKET", idTicket);
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ModificarPrecio(Ticket ticket,double precio)
        {

            try
            {
                SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString);

                using (conexion)
                {
                    conexion.Open();
                    string queryModificarPrecio = "UPDATE TICKET SET PRECIO = @PRECIO WHERE ID_TICKET = @ID_TICKET; ";


                    using (SqlCommand command = new SqlCommand(queryModificarPrecio, conexion))
                    {
                        command.Parameters.AddWithValue("@ID_TICKET", ticket.TicketId);
                        command.Parameters.AddWithValue("@PRECIO", precio);
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

