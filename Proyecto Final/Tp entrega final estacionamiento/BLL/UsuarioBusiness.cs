using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Net.Mime.MediaTypeNames;

namespace BLL
{
    public class UsuarioBusiness
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();


        public void AltaUsuarios(Usuario userAlta)
        {
            try
            {
                List<Usuario> Lusuarios = new List<Usuario>();
                Lusuarios = usuarioDAO.ObtenerUsuariosBD();
                
                using (var trx = new TransactionScope())
                {
                    foreach (var usuario in Lusuarios)
                    {
                        if(usuario.Email == userAlta.Email)
                        {
                            throw new Exception("El usuario ya existe");
                        }
                    }  

                    if (userAlta.Nombre == "" || userAlta.Nombre.Length < 3)
                    {
                        throw new Exception("El nombre no puede ser vacio ni tener una longitud menor a 3");
                    }
                    if (userAlta.Apellido == "" || userAlta.Apellido.Length < 3)
                    {
                        throw new Exception("El apellido no puede ser vacio ni tener una longitud menor a 3");
                    }
                    if (userAlta.Email == "" || userAlta.Email.Length < 5 || !userAlta.Email.Contains('@'))
                    {
                        throw new Exception("El correo tiene que tener @ no puede ser vacio ni tener una longitud menor a 5");
                    }

                    usuarioDAO.AltaUsuarioDB(userAlta);
                    trx.Complete();
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> Lusuarios = new List<Usuario>();
            try
            {

                return usuarioDAO.ObtenerUsuariosBD();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<object> MostrarGrillaDB(List<Usuario> ListarUsuarios)
        {
            List<object> UsuariosEnBase = new List<object>();

            // Iteramos sobre cada aplicación
            foreach (var usuarios in ListarUsuarios)
            {
                var user = new
                {
                    IdUsuario = usuarios.UsuarioId,
                    Nombre = usuarios.Nombre,
                    Apellido = usuarios.Apellido,
                    Email = usuarios.Email,
                    Telefono = usuarios.Telefono,
                };

                // Añadimos el objeto anónimo a la lista
                UsuariosEnBase.Add(user);
            }

            return UsuariosEnBase;
        }

        public List<object> MostrarGrillaBorrador(List<Usuario> Listasusuarios)
        {
            List<object> UsuariosEnBase = new List<object>();

            // Iteramos sobre cada aplicación
            foreach (var usuarios in Listasusuarios)
            {
                var user = new
                {
                    IdUsuario = usuarios.UsuarioId,
                    Nombre = usuarios.Nombre,
                    Apellido = usuarios.Apellido,
                    Email = usuarios.Email,
                    Telefono = usuarios.Telefono,
                };

                // Añadimos el objeto anónimo a la lista
                UsuariosEnBase.Add(user);
            }

            return UsuariosEnBase;

        }

        public void AltaListaBorrador(List<Usuario> lUsuariosBorrador)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    foreach (Usuario user in lUsuariosBorrador)
                    {
                        AltaUsuarios(user);
                    }
                    trx.Complete();
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void EliminarUsuario(int IDUsuario)
        {
            try
            {
                usuarioDAO.EliminarUsuarioDB(IDUsuario);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
