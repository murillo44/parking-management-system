namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtNombreUsuario = new TextBox();
            TxtApellidoUsuario = new TextBox();
            TxtEmailUsuario = new TextBox();
            TxtTelefonoUsuario = new TextBox();
            button1 = new Button();
            DGVUsuarios = new DataGridView();
            label1 = new Label();
            BtnAgregarBorrador = new Button();
            BtnConfirmarBorrador = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DGVListaEstacionamientos = new DataGridView();
            BtnCrearEstacionamiento = new Button();
            TxtCapacidadEstacionamiento = new TextBox();
            TxtDireccionEstacionamiento = new TextBox();
            TxtNombreAltaEstacionamiento = new TextBox();
            label5 = new Label();
            label6 = new Label();
            DGVListaTickets = new DataGridView();
            BtnGenerarTicket = new Button();
            label7 = new Label();
            CmbUsuarios = new ComboBox();
            CmbEstacionamientos = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            DGVUserBorrador = new DataGridView();
            CmbUsuario = new ComboBox();
            CmbTicket = new ComboBox();
            CmbEstacionamiento = new ComboBox();
            BtnSalirEstacionamiento = new Button();
            label10 = new Label();
            label11 = new Label();
            Ticket = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVListaEstacionamientos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVListaTickets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVUserBorrador).BeginInit();
            SuspendLayout();
            // 
            // TxtNombreUsuario
            // 
            TxtNombreUsuario.Location = new Point(70, 136);
            TxtNombreUsuario.Margin = new Padding(3, 4, 3, 4);
            TxtNombreUsuario.Name = "TxtNombreUsuario";
            TxtNombreUsuario.PlaceholderText = "NOMBRE";
            TxtNombreUsuario.Size = new Size(173, 27);
            TxtNombreUsuario.TabIndex = 0;
            // 
            // TxtApellidoUsuario
            // 
            TxtApellidoUsuario.Location = new Point(70, 193);
            TxtApellidoUsuario.Margin = new Padding(3, 4, 3, 4);
            TxtApellidoUsuario.Name = "TxtApellidoUsuario";
            TxtApellidoUsuario.PlaceholderText = "APELLIDO";
            TxtApellidoUsuario.Size = new Size(173, 27);
            TxtApellidoUsuario.TabIndex = 1;
            // 
            // TxtEmailUsuario
            // 
            TxtEmailUsuario.Location = new Point(67, 255);
            TxtEmailUsuario.Margin = new Padding(3, 4, 3, 4);
            TxtEmailUsuario.Name = "TxtEmailUsuario";
            TxtEmailUsuario.PlaceholderText = "EMAIL";
            TxtEmailUsuario.Size = new Size(173, 27);
            TxtEmailUsuario.TabIndex = 2;
            // 
            // TxtTelefonoUsuario
            // 
            TxtTelefonoUsuario.Location = new Point(70, 312);
            TxtTelefonoUsuario.Margin = new Padding(3, 4, 3, 4);
            TxtTelefonoUsuario.Name = "TxtTelefonoUsuario";
            TxtTelefonoUsuario.PlaceholderText = "TELEFONO";
            TxtTelefonoUsuario.Size = new Size(173, 27);
            TxtTelefonoUsuario.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(70, 364);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(174, 60);
            button1.TabIndex = 4;
            button1.Text = "Crear Usuario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DGVUsuarios
            // 
            DGVUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVUsuarios.Location = new Point(288, 136);
            DGVUsuarios.Margin = new Padding(3, 4, 3, 4);
            DGVUsuarios.Name = "DGVUsuarios";
            DGVUsuarios.RowHeadersWidth = 51;
            DGVUsuarios.Size = new Size(520, 304);
            DGVUsuarios.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 96);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 6;
            label1.Text = "Alta de Usuarios";
            // 
            // BtnAgregarBorrador
            // 
            BtnAgregarBorrador.Location = new Point(70, 432);
            BtnAgregarBorrador.Margin = new Padding(3, 4, 3, 4);
            BtnAgregarBorrador.Name = "BtnAgregarBorrador";
            BtnAgregarBorrador.Size = new Size(82, 100);
            BtnAgregarBorrador.TabIndex = 7;
            BtnAgregarBorrador.Text = "Agregar Al Borrador";
            BtnAgregarBorrador.UseVisualStyleBackColor = true;
            BtnAgregarBorrador.Click += BtnAgregarBorrador_Click;
            // 
            // BtnConfirmarBorrador
            // 
            BtnConfirmarBorrador.Location = new Point(159, 432);
            BtnConfirmarBorrador.Margin = new Padding(3, 4, 3, 4);
            BtnConfirmarBorrador.Name = "BtnConfirmarBorrador";
            BtnConfirmarBorrador.Size = new Size(85, 67);
            BtnConfirmarBorrador.TabIndex = 8;
            BtnConfirmarBorrador.Text = "Confirmar Cambios";
            BtnConfirmarBorrador.UseVisualStyleBackColor = true;
            BtnConfirmarBorrador.Click += BtnConfirmarBorrador_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 112);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 9;
            label2.Text = "Lista de Usuarios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1080, 556);
            label3.Name = "label3";
            label3.Size = new Size(180, 20);
            label3.TabIndex = 17;
            label3.Text = "Lista de Estacionamientos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(877, 540);
            label4.Name = "label4";
            label4.Size = new Size(171, 20);
            label4.TabIndex = 16;
            label4.Text = "Alta de Estacionamiento";
            // 
            // DGVListaEstacionamientos
            // 
            DGVListaEstacionamientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVListaEstacionamientos.Location = new Point(1080, 580);
            DGVListaEstacionamientos.Margin = new Padding(3, 4, 3, 4);
            DGVListaEstacionamientos.Name = "DGVListaEstacionamientos";
            DGVListaEstacionamientos.RowHeadersWidth = 51;
            DGVListaEstacionamientos.Size = new Size(549, 304);
            DGVListaEstacionamientos.TabIndex = 15;
            // 
            // BtnCrearEstacionamiento
            // 
            BtnCrearEstacionamiento.Location = new Point(877, 752);
            BtnCrearEstacionamiento.Margin = new Padding(3, 4, 3, 4);
            BtnCrearEstacionamiento.Name = "BtnCrearEstacionamiento";
            BtnCrearEstacionamiento.Size = new Size(174, 60);
            BtnCrearEstacionamiento.TabIndex = 14;
            BtnCrearEstacionamiento.Text = "Crear Estacionamiento";
            BtnCrearEstacionamiento.UseVisualStyleBackColor = true;
            BtnCrearEstacionamiento.Click += BtnCrearEstacionamiento_Click;
            // 
            // TxtCapacidadEstacionamiento
            // 
            TxtCapacidadEstacionamiento.Location = new Point(874, 699);
            TxtCapacidadEstacionamiento.Margin = new Padding(3, 4, 3, 4);
            TxtCapacidadEstacionamiento.Name = "TxtCapacidadEstacionamiento";
            TxtCapacidadEstacionamiento.PlaceholderText = "CAPACIDAD";
            TxtCapacidadEstacionamiento.Size = new Size(173, 27);
            TxtCapacidadEstacionamiento.TabIndex = 12;
            // 
            // TxtDireccionEstacionamiento
            // 
            TxtDireccionEstacionamiento.Location = new Point(877, 637);
            TxtDireccionEstacionamiento.Margin = new Padding(3, 4, 3, 4);
            TxtDireccionEstacionamiento.Name = "TxtDireccionEstacionamiento";
            TxtDireccionEstacionamiento.PlaceholderText = "DIRECCION";
            TxtDireccionEstacionamiento.Size = new Size(173, 27);
            TxtDireccionEstacionamiento.TabIndex = 11;
            // 
            // TxtNombreAltaEstacionamiento
            // 
            TxtNombreAltaEstacionamiento.Location = new Point(877, 580);
            TxtNombreAltaEstacionamiento.Margin = new Padding(3, 4, 3, 4);
            TxtNombreAltaEstacionamiento.Name = "TxtNombreAltaEstacionamiento";
            TxtNombreAltaEstacionamiento.PlaceholderText = "NOMBRE";
            TxtNombreAltaEstacionamiento.Size = new Size(173, 27);
            TxtNombreAltaEstacionamiento.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1080, 112);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 24;
            label5.Text = "Lista de Tickets";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(877, 96);
            label6.Name = "label6";
            label6.Size = new Size(154, 20);
            label6.TabIndex = 23;
            label6.Text = "Generacion de Tickets";
            // 
            // DGVListaTickets
            // 
            DGVListaTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVListaTickets.Location = new Point(1080, 136);
            DGVListaTickets.Margin = new Padding(3, 4, 3, 4);
            DGVListaTickets.Name = "DGVListaTickets";
            DGVListaTickets.RowHeadersWidth = 51;
            DGVListaTickets.Size = new Size(549, 304);
            DGVListaTickets.TabIndex = 22;
            // 
            // BtnGenerarTicket
            // 
            BtnGenerarTicket.Location = new Point(877, 296);
            BtnGenerarTicket.Margin = new Padding(3, 4, 3, 4);
            BtnGenerarTicket.Name = "BtnGenerarTicket";
            BtnGenerarTicket.Size = new Size(174, 60);
            BtnGenerarTicket.TabIndex = 21;
            BtnGenerarTicket.Text = "Generar Ticket";
            BtnGenerarTicket.UseVisualStyleBackColor = true;
            BtnGenerarTicket.Click += BtnGenerarTicket_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(877, 136);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 25;
            label7.Text = "Usuario:";
            // 
            // CmbUsuarios
            // 
            CmbUsuarios.FormattingEnabled = true;
            CmbUsuarios.Location = new Point(877, 160);
            CmbUsuarios.Margin = new Padding(3, 4, 3, 4);
            CmbUsuarios.Name = "CmbUsuarios";
            CmbUsuarios.Size = new Size(171, 28);
            CmbUsuarios.TabIndex = 26;
            // 
            // CmbEstacionamientos
            // 
            CmbEstacionamientos.FormattingEnabled = true;
            CmbEstacionamientos.Location = new Point(877, 237);
            CmbEstacionamientos.Margin = new Padding(3, 4, 3, 4);
            CmbEstacionamientos.Name = "CmbEstacionamientos";
            CmbEstacionamientos.Size = new Size(171, 28);
            CmbEstacionamientos.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(877, 213);
            label8.Name = "label8";
            label8.Size = new Size(122, 20);
            label8.TabIndex = 27;
            label8.Text = "Estacionamiento:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(70, 556);
            label9.Name = "label9";
            label9.Size = new Size(183, 20);
            label9.TabIndex = 30;
            label9.Text = "Lista Borrador de Usuarios";
            // 
            // DGVUserBorrador
            // 
            DGVUserBorrador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVUserBorrador.Location = new Point(70, 580);
            DGVUserBorrador.Margin = new Padding(3, 4, 3, 4);
            DGVUserBorrador.Name = "DGVUserBorrador";
            DGVUserBorrador.RowHeadersWidth = 51;
            DGVUserBorrador.Size = new Size(738, 304);
            DGVUserBorrador.TabIndex = 29;
            // 
            // CmbUsuario
            // 
            CmbUsuario.FormattingEnabled = true;
            CmbUsuario.Location = new Point(608, 937);
            CmbUsuario.Margin = new Padding(3, 4, 3, 4);
            CmbUsuario.Name = "CmbUsuario";
            CmbUsuario.Size = new Size(171, 28);
            CmbUsuario.TabIndex = 31;
            // 
            // CmbTicket
            // 
            CmbTicket.FormattingEnabled = true;
            CmbTicket.Location = new Point(965, 937);
            CmbTicket.Margin = new Padding(3, 4, 3, 4);
            CmbTicket.Name = "CmbTicket";
            CmbTicket.Size = new Size(171, 28);
            CmbTicket.TabIndex = 32;
            // 
            // CmbEstacionamiento
            // 
            CmbEstacionamiento.FormattingEnabled = true;
            CmbEstacionamiento.Location = new Point(786, 937);
            CmbEstacionamiento.Margin = new Padding(3, 4, 3, 4);
            CmbEstacionamiento.Name = "CmbEstacionamiento";
            CmbEstacionamiento.Size = new Size(171, 28);
            CmbEstacionamiento.TabIndex = 33;
            // 
            // BtnSalirEstacionamiento
            // 
            BtnSalirEstacionamiento.Location = new Point(378, 913);
            BtnSalirEstacionamiento.Margin = new Padding(3, 4, 3, 4);
            BtnSalirEstacionamiento.Name = "BtnSalirEstacionamiento";
            BtnSalirEstacionamiento.Size = new Size(171, 60);
            BtnSalirEstacionamiento.TabIndex = 34;
            BtnSalirEstacionamiento.Text = "Salir del Estacionamiento";
            BtnSalirEstacionamiento.UseVisualStyleBackColor = true;
            BtnSalirEstacionamiento.Click += BtnSalirEstacionamiento_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(608, 913);
            label10.Name = "label10";
            label10.Size = new Size(62, 20);
            label10.TabIndex = 35;
            label10.Text = "Usuario:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(786, 913);
            label11.Name = "label11";
            label11.Size = new Size(122, 20);
            label11.TabIndex = 36;
            label11.Text = "Estacionamiento:";
            // 
            // Ticket
            // 
            Ticket.AutoSize = true;
            Ticket.Location = new Point(965, 913);
            Ticket.Name = "Ticket";
            Ticket.Size = new Size(51, 20);
            Ticket.TabIndex = 37;
            Ticket.Text = "Ticket:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1641, 981);
            Controls.Add(Ticket);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(BtnSalirEstacionamiento);
            Controls.Add(CmbEstacionamiento);
            Controls.Add(CmbTicket);
            Controls.Add(CmbUsuario);
            Controls.Add(label9);
            Controls.Add(DGVUserBorrador);
            Controls.Add(CmbEstacionamientos);
            Controls.Add(label8);
            Controls.Add(CmbUsuarios);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(DGVListaTickets);
            Controls.Add(BtnGenerarTicket);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(DGVListaEstacionamientos);
            Controls.Add(BtnCrearEstacionamiento);
            Controls.Add(TxtCapacidadEstacionamiento);
            Controls.Add(TxtDireccionEstacionamiento);
            Controls.Add(TxtNombreAltaEstacionamiento);
            Controls.Add(label2);
            Controls.Add(BtnConfirmarBorrador);
            Controls.Add(BtnAgregarBorrador);
            Controls.Add(label1);
            Controls.Add(DGVUsuarios);
            Controls.Add(button1);
            Controls.Add(TxtTelefonoUsuario);
            Controls.Add(TxtEmailUsuario);
            Controls.Add(TxtApellidoUsuario);
            Controls.Add(TxtNombreUsuario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGVUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVListaEstacionamientos).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVListaTickets).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVUserBorrador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNombreUsuario;
        private TextBox TxtApellidoUsuario;
        private TextBox TxtEmailUsuario;
        private TextBox TxtTelefonoUsuario;
        private Button button1;
        private DataGridView DGVUsuarios;
        private Label label1;
        private Button BtnAgregarBorrador;
        private Button BtnConfirmarBorrador;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView DGVListaEstacionamientos;
        private Button BtnCrearEstacionamiento;
        private TextBox TxtCapacidadEstacionamiento;
        private TextBox TxtDireccionEstacionamiento;
        private TextBox TxtNombreAltaEstacionamiento;
        private Label label5;
        private Label label6;
        private DataGridView DGVListaTickets;
        private Button BtnGenerarTicket;
        private Label label7;
        private ComboBox CmbUsuarios;
        private ComboBox CmbEstacionamientos;
        private Label label8;
        private Label label9;
        private DataGridView DGVUserBorrador;
        private ComboBox CmbUsuario;
        private ComboBox CmbTicket;
        private ComboBox CmbEstacionamiento;
        private Button BtnSalirEstacionamiento;
        private Label label10;
        private Label label11;
        private Label Ticket;
    }
}
