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
    public class UsuarioDAO
    {
        public void AltaUsuarioDB(Usuario userAlta)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString);
                using (conexion)
                {
                    conexion.Open();
                    string queryAltaUser = "INSERT INTO USUARIO(NOMBRE,APELLIDO,EMAIL,TELEFONO) Values (@NOMBRE,@APELLIDO,@EMAIL,@TELEFONO); ";
                    using (SqlCommand command = new SqlCommand(queryAltaUser, conexion))
                    {
                        command.Parameters.AddWithValue("@NOMBRE", userAlta.Nombre);
                        command.Parameters.AddWithValue("@APELLIDO", userAlta.Apellido);
                        command.Parameters.AddWithValue("@EMAIL", userAlta.Email);
                        command.Parameters.AddWithValue("@TELEFONO", userAlta.Telefono);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public Usuario BuscarUsuariosPorID(int IDUsuario)
        {
            Usuario usuarios = new Usuario();
            try
            {
                SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString);
                using (conexion)
                {
                    conexion.Open();
                    string queryBuscarUserPorID = "SELECT ID_USUARIO,NOMBRE,APELLIDO,EMAIL,TELEFONO FROM USUARIO WHERE ID_USUARIO= @ID_USUARIO";
                    using (SqlCommand command = new SqlCommand(queryBuscarUserPorID, conexion))
                    {
                        command.Parameters.AddWithValue("@ID_USUARIO", IDUsuario);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                usuarios = UsuarioMapper.MapUsuario(reader);
                            }
                        }
                    }
                }

                return usuarios;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Usuario> ObtenerUsuariosBD()
        {
            List<Usuario> LUser = new List<Usuario>();
            try
            {
                SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString);
                using (conexion)
                {
                    conexion.Open();
                    string queryBuscarUser = "SELECT ID_USUARIO,NOMBRE,APELLIDO,EMAIL,TELEFONO FROM USUARIO";
                    using (SqlCommand command = new SqlCommand(queryBuscarUser, conexion))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Usuario user = new Usuario();

                                user = UsuarioMapper.MapUsuario(reader);
                                LUser.Add(user);
                            }
                        }
                    }
                }
                return LUser;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void EliminarUsuarioDB(int IDUsuario)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString);
                using (conexion)
                {
                    conexion.Open();
                    string queryEliminarUser = "DELETE FROM USUARIO WHERE ID_USUARIO= @ID_USUARIO";
                    using (SqlCommand command = new SqlCommand(queryEliminarUser, conexion))
                    {
                        command.Parameters.AddWithValue("@ID_USUARIO", IDUsuario);
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
