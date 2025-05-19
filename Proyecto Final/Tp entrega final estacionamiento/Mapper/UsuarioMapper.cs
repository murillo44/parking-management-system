using Entity;
using System.Data.SqlClient;

namespace Mapper
{
    public class UsuarioMapper
    {

        public static Usuario MapUsuario(SqlDataReader reader)
        {
            Usuario user = new Usuario();
            try
            {
                user.UsuarioId = Convert.ToInt32(reader["ID_USUARIO"].ToString());
                user.Nombre = reader["NOMBRE"].ToString();
                user.Apellido = reader["APELLIDO"].ToString();
                user.Email = reader["EMAIL"].ToString();
                user.Telefono = Convert.ToInt32(reader["TELEFONO"].ToString());
                return user;
            }
            catch (Exception ex)
            {

                throw;
            }
        }


    }
}
