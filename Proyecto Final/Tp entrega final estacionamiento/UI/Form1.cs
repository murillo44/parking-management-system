using BLL;
using DAL;
using Entity;
namespace UI

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UsuarioBusiness usuarioBLL = new UsuarioBusiness();
        TicketBusiness ticketBLL = new TicketBusiness();
        EstacionamientBusiness estacionamientBusiness = new EstacionamientBusiness();
        List<Usuario> LusuarioBorrador = new List<Usuario>();

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarGrillas();
            CargarCombobox();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario user = new Usuario();
                user.Nombre = TxtNombreUsuario.Text;
                user.Apellido = TxtApellidoUsuario.Text;
                user.Email = TxtEmailUsuario.Text;
                user.Telefono = Convert.ToInt32(TxtTelefonoUsuario.Text);
                usuarioBLL.AltaUsuarios(user);
                CargarCombobox();
                ActualizarGrillas();
                LimpiarTxT();
                MessageBox.Show("Usuario creado correctamente.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarGrillas()
        {
            try
            {
                DGVUsuarios.DataSource = null;
                if (usuarioBLL.ObtenerUsuarios() != null)
                {
                    DGVUsuarios.DataSource = usuarioBLL.MostrarGrillaDB(usuarioBLL.ObtenerUsuarios()).ToList();
                }

                DGVListaEstacionamientos.DataSource = null;
                if (estacionamientBusiness.ObtenerEstacionamientos() != null)
                {
                    DGVListaEstacionamientos.DataSource = estacionamientBusiness.MostrarGrillaEstacionamientoDB(estacionamientBusiness.ObtenerEstacionamientos()).ToList();
                }

                DGVListaTickets.DataSource = null;
                if (ticketBLL.ObtenerTickets() != null)
                {
                    DGVListaTickets.DataSource = ticketBLL.MostrarTicketsDB(ticketBLL.ObtenerTickets()).ToList();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void BtnAgregarBorrador_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario user = new Usuario();
                user.Nombre = TxtNombreUsuario.Text;
                user.Apellido = TxtApellidoUsuario.Text;
                user.Email = TxtEmailUsuario.Text;
                user.Telefono = Convert.ToInt32(TxtTelefonoUsuario.Text);

                LusuarioBorrador.Add(user);
                ActualizarGrillaBorrador();
                ActualizarGrillas();
                LimpiarTxT();
                MessageBox.Show("Usuario añadido al borrador.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LusuarioBorrador.Clear();
                ActualizarGrillaBorrador();
                LimpiarTxT();
            }

        }
        private void ActualizarGrillaBorrador()
        {
            try
            {
                DGVUserBorrador.DataSource = null;
                if (LusuarioBorrador.Count > 0)
                {
                    DGVUserBorrador.DataSource = usuarioBLL.MostrarGrillaBorrador(LusuarioBorrador).ToList();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnConfirmarBorrador_Click(object sender, EventArgs e)
        {
            try
            {
                if (LusuarioBorrador.Count < 1)
                {
                    throw new Exception("No hay elementos en la lista borrador para agregar");
                }
                usuarioBLL.AltaListaBorrador(LusuarioBorrador);
                LusuarioBorrador.Clear();
                ActualizarGrillaBorrador();
                ActualizarGrillas();
                CargarCombobox();
                LimpiarTxT();

                MessageBox.Show("Alta de lista borrador exitosa !");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                LusuarioBorrador.Clear();
                ActualizarGrillaBorrador();
                LimpiarTxT();
            }
        }

        private void BtnCrearEstacionamiento_Click(object sender, EventArgs e)
        {
            try
            {
                Estacionamiento estac = new Estacionamiento();
                estac.Nombre = TxtNombreAltaEstacionamiento.Text;
                estac.Direccion = TxtDireccionEstacionamiento.Text;
                estac.Capacidad = Convert.ToInt32(TxtCapacidadEstacionamiento.Text);
                estacionamientBusiness.AltaEstacionamiento(estac);
                ActualizarGrillas();
                CargarCombobox();
                LimpiarTxT();
                MessageBox.Show("Se creo un nuevo estacionamiento correctamente.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LimpiarTxT()
        {
            TxtApellidoUsuario.Text = "";
            TxtCapacidadEstacionamiento.Text = "";
            TxtDireccionEstacionamiento.Text = "";
            TxtEmailUsuario.Text = "";
            TxtNombreUsuario.Text = "";
            TxtTelefonoUsuario.Text = "";
            TxtNombreAltaEstacionamiento.Text = "";
            
        }
        private void EliminarAll()
        {
            try
            {
                ticketBLL.ModificarTicket(Convert.ToInt32(CmbTicket.SelectedValue.ToString()),(Convert.ToInt32(CmbEstacionamiento.SelectedValue.ToString())),(Convert.ToInt32(CmbUsuario.SelectedValue.ToString())));
                estacionamientBusiness.ModificarEstacionamiento(Convert.ToInt32(CmbEstacionamiento.SelectedValue.ToString()));
                MessageBox.Show("El ticket fue aprobado y puede salir del estacionamiento. El precio es: " + ticketBLL.CalcularCostos(Convert.ToInt32(CmbTicket.SelectedValue.ToString())));
                ActualizarGrillas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnSalirEstacionamiento_Click(object sender, EventArgs e)
        {
            EliminarAll();
        }

        private void CargarCombobox()
        {
            try
            {
                CmbUsuarios.DataSource = null;
                CmbUsuarios.DataSource = usuarioBLL.ObtenerUsuarios();
                CmbUsuarios.ValueMember = "UsuarioId";
                CmbUsuarios.DisplayMember = "Email";
                CmbEstacionamientos.DataSource = null;
                CmbEstacionamientos.DataSource = estacionamientBusiness.ObtenerEstacionamientos();
                CmbEstacionamientos.ValueMember = "EstacionamientoId";
                CmbEstacionamientos.DisplayMember = "Nombre";
                CmbUsuario.DataSource = null;
                CmbUsuario.DataSource = usuarioBLL.ObtenerUsuarios();
                CmbUsuario.ValueMember = "UsuarioId";
                CmbUsuario.DisplayMember = "Email";
                CmbEstacionamiento.DataSource = null;
                CmbEstacionamiento.DataSource = estacionamientBusiness.ObtenerEstacionamientos();
                CmbEstacionamiento.ValueMember = "EstacionamientoId";
                CmbEstacionamiento.DisplayMember = "Nombre";
                CmbTicket.DataSource = null;
                CmbTicket.DataSource = ticketBLL.ObtenerTickets();
                CmbTicket.ValueMember = "TicketId";
                CmbTicket.DisplayMember = "TicketId";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnGenerarTicket_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket ticket = new Ticket();
                Usuario user = new Usuario();
                Estacionamiento est = new Estacionamiento();
                ticket.UsuarioId = user;
                ticket.EstacionamientoId = est;
                ticket.UsuarioId.UsuarioId = Convert.ToInt32(CmbUsuarios.SelectedValue.ToString());
                ticket.EstacionamientoId.EstacionamientoId = Convert.ToInt32(CmbEstacionamientos.SelectedValue.ToString());                
                ticketBLL.AltaTicket(ticket,est);
                ActualizarGrillas();
                CargarCombobox();
                MessageBox.Show("Ticket de estacionamiento creado correctamente, NO LO PIERDA!");
                LimpiarTxT();

                                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
