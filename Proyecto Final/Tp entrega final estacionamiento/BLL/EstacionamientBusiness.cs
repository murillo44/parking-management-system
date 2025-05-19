using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class EstacionamientBusiness
    {
        EstacionamientoDAO estacionamientoDAO = new EstacionamientoDAO();
        public void AltaEstacionamiento(Estacionamiento EstacionamientoAlta)
        {
            try
            {               
                using (var trx = new TransactionScope())
                {
                    if (EstacionamientoAlta.Nombre == "" || EstacionamientoAlta.Nombre.Length < 3)
                    {
                        throw new Exception("El nombre no puede ser vacio ni tener una longitud menor a 3");
                    }
                    if (EstacionamientoAlta.Direccion == "" || EstacionamientoAlta.Direccion.Length < 5)
                    {
                        throw new Exception("La dirección no puede ser vacio ni tener una longitud menor a 5");
                    }
                    

                    estacionamientoDAO.AltaEstacionamiento(EstacionamientoAlta);
                    trx.Complete();
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public List<Estacionamiento> ObtenerEstacionamientos()
        {
            List<Estacionamiento> Lestacionamiento = new List<Estacionamiento>();
            try
            {
                return estacionamientoDAO.ObtenerEstacionamientosBD();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<object> MostrarGrillaEstacionamientoDB(List<Estacionamiento> ListarEstacionamientos)
        {
            List<object> EstacionamientosEnBase = new List<object>();

            // Iteramos sobre cada aplicación
            foreach (var estacionamiento in ListarEstacionamientos)
            {
                var estac = new
                {
                    EstacionamientoId = estacionamiento.EstacionamientoId,
                    Nombre = estacionamiento.Nombre,
                    Direccion = estacionamiento.Direccion,
                    Capacidad = estacionamiento.Capacidad,
                    Ocupados = estacionamiento.Ocupados,
                };

                // Añadimos el objeto anónimo a la lista
                EstacionamientosEnBase.Add(estac);
            }

            return EstacionamientosEnBase;
        }
        public void ModificarEstacionamiento(int idEstacionamiento)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    estacionamientoDAO.ModificarEstacionamiento(idEstacionamiento);
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
