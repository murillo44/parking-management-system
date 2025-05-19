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
    public class EstacionamientoDAO
    {
        public void AltaEstacionamiento(Estacionamiento estacionamiento)
        {

            try
            {
                SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString);

                using (conexion)
                {
                    conexion.Open();
                    string queryAltaEstacionamiento = "INSERT INTO ESTACIONAMIENTO(NOMBRE,DIRECCION,CAPACIDAD,OCUPADOS) Values (@NOMBRE,@DIRECCION,@CAPACIDAD,@OCUPADOS); ";

                    using (SqlCommand command = new SqlCommand(queryAltaEstacionamiento, conexion))
                    {
                        command.Parameters.AddWithValue("@NOMBRE", estacionamiento.Nombre);
                        command.Parameters.AddWithValue("@DIRECCION", estacionamiento.Direccion);
                        command.Parameters.AddWithValue("@CAPACIDAD", estacionamiento.Capacidad);
                        command.Parameters.AddWithValue("@OCUPADOS", estacionamiento.Ocupados);
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Estacionamiento BuscarEstacionamientoPorID(int IDEstacionamiento)
        {
            Estacionamiento estacionamiento = new Estacionamiento();
            try
            {
                SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString);
                using (conexion)
                {
                    conexion.Open();
                    string queryBuscarEstacionamientoPorID = "SELECT ID_ESTACIONAMIENTO,NOMBRE,DIRECCION,CAPACIDAD,OCUPADOS FROM ESTACIONAMIENTO WHERE ID_ESTACIONAMIENTO= @ID_ESTACIONAMIENTO";
                    using (SqlCommand command = new SqlCommand(queryBuscarEstacionamientoPorID, conexion))
                    {
                        command.Parameters.AddWithValue("@ID_ESTACIONAMIENTO", IDEstacionamiento);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                estacionamiento = EstacionamientoMapper.MapEstacionamiento(reader);
                            }
                        }
                    }
                }
                return estacionamiento;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Estacionamiento> ObtenerEstacionamientosBD()
        {
            List<Estacionamiento> Lest = new List<Estacionamiento>();
            try
            {
                SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString);
                using (conexion)
                {
                    conexion.Open();
                    string queryBuscarEstacionamiento = "SELECT ID_ESTACIONAMIENTO,NOMBRE,DIRECCION,CAPACIDAD,OCUPADOS FROM ESTACIONAMIENTO";
                    using (SqlCommand command = new SqlCommand(queryBuscarEstacionamiento, conexion))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Estacionamiento estac = new Estacionamiento();

                                estac = EstacionamientoMapper.MapEstacionamiento(reader);
                                Lest.Add(estac);
                            }
                        }
                    }
                }
                return Lest;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void ModificarEstacionamiento(int idEstacionamiento)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString);
                using (conexion)
                {
                    conexion.Open();
                    string queryEliminarEstacionamiento = "UPDATE ESTACIONAMIENTO SET Ocupados = Ocupados - 1 WHERE ID_ESTACIONAMIENTO = @ID_ESTACIONAMIENTO";
                    using (SqlCommand command = new SqlCommand(queryEliminarEstacionamiento, conexion))
                    {
                        command.Parameters.AddWithValue("@ID_ESTACIONAMIENTO", idEstacionamiento);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}



