using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class EstacionamientoMapper
    {
        public static Estacionamiento MapEstacionamiento(SqlDataReader reader)
        {
            Estacionamiento est = new Estacionamiento();
            try
            {
                est.EstacionamientoId = Convert.ToInt32(reader["ID_ESTACIONAMIENTO"].ToString());
                est.Nombre = reader["NOMBRE"].ToString();
                est.Direccion = reader["DIRECCION"].ToString();
                est.Capacidad = Convert.ToInt32(reader["CAPACIDAD"].ToString());
                est.Ocupados = Convert.ToInt32(reader["OCUPADOS"].ToString());
                return est;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
