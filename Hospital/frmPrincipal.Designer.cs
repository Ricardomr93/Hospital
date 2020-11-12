namespace Hospital
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.lblDatos = new System.Windows.Forms.Label();
            this.pcbDatos = new System.Windows.Forms.PictureBox();
            this.lblHospi = new System.Windows.Forms.Label();
            this.pnlAtencion = new System.Windows.Forms.Panel();
            this.cmbbNomAten = new System.Windows.Forms.ComboBox();
            this.lblNoIDAten = new System.Windows.Forms.Label();
            this.lblIDAten = new System.Windows.Forms.Label();
            this.dtpFechaAten = new System.Windows.Forms.DateTimePicker();
            this.btnAnCita = new System.Windows.Forms.Button();
            this.lblPacAten = new System.Windows.Forms.Label();
            this.cmbbPacAten = new System.Windows.Forms.ComboBox();
            this.lblNombreAten = new System.Windows.Forms.Label();
            this.cmbbEspeAten = new System.Windows.Forms.ComboBox();
            this.lblEspeAten = new System.Windows.Forms.Label();
            this.lblFechaAten = new System.Windows.Forms.Label();
            this.pcbAten = new System.Windows.Forms.PictureBox();
            this.lblAten = new System.Windows.Forms.Label();
            this.pnlMedico = new System.Windows.Forms.Panel();
            this.lblNoIDMed = new System.Windows.Forms.Label();
            this.txtNomMed = new System.Windows.Forms.TextBox();
            this.txtEspeMed = new System.Windows.Forms.TextBox();
            this.btnGesMed = new System.Windows.Forms.Button();
            this.txtMovMed = new System.Windows.Forms.TextBox();
            this.lblEspeMed = new System.Windows.Forms.Label();
            this.txtApellMed = new System.Windows.Forms.TextBox();
            this.lblMovilMed = new System.Windows.Forms.Label();
            this.lblApellMed = new System.Windows.Forms.Label();
            this.lblNombreMed = new System.Windows.Forms.Label();
            this.lblIDMed = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.pcbMed = new System.Windows.Forms.PictureBox();
            this.pnlPaciente = new System.Windows.Forms.Panel();
            this.lblNoIDPac = new System.Windows.Forms.Label();
            this.btnGesPac = new System.Windows.Forms.Button();
            this.txtADesPac = new System.Windows.Forms.TextBox();
            this.lblAlerPac = new System.Windows.Forms.Label();
            this.txtAlerPac = new System.Windows.Forms.TextBox();
            this.lblADesPac = new System.Windows.Forms.Label();
            this.lblIDPac = new System.Windows.Forms.Label();
            this.txtLocPac = new System.Windows.Forms.TextBox();
            this.pcbPac = new System.Windows.Forms.PictureBox();
            this.txtApellPac = new System.Windows.Forms.TextBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.txtNomPac = new System.Windows.Forms.TextBox();
            this.lblNomPac = new System.Windows.Forms.Label();
            this.lblLocPac = new System.Windows.Forms.Label();
            this.lblApellPac = new System.Windows.Forms.Label();
            this.pnlfecha = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlCitasMed = new System.Windows.Forms.Panel();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.btnActMedCita = new System.Windows.Forms.Button();
            this.lblNoIDMedCita = new System.Windows.Forms.Label();
            this.lblIDMedCita = new System.Windows.Forms.Label();
            this.lblNomEspeCita = new System.Windows.Forms.Label();
            this.lblEspeCita = new System.Windows.Forms.Label();
            this.cmbbMedCita = new System.Windows.Forms.ComboBox();
            this.pcbCita = new System.Windows.Forms.PictureBox();
            this.lblMedCita = new System.Windows.Forms.Label();
            this.lblCitas = new System.Windows.Forms.Label();
            this.btnPacMedDia = new System.Windows.Forms.Button();
            this.btnHisto = new System.Windows.Forms.Button();
            this.rljFecha = new System.Windows.Forms.Timer(this.components);
            this.rljHora = new System.Windows.Forms.Timer(this.components);
            this.medicosibfk1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.idatencDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atenmedpacBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDs = new Hospital.hospitalDs();
            this.especialidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.especialidadesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.atenmedpacBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.atenmedpacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicosTableAdapter = new Hospital.hospitalDsTableAdapters.medicosTableAdapter();
            this.atenmedpacTableAdapter = new Hospital.hospitalDsTableAdapters.atenmedpacTableAdapter();
            this.tableAdapterManager = new Hospital.hospitalDsTableAdapters.TableAdapterManager();
            this.especialidadesTableAdapter = new Hospital.hospitalDsTableAdapters.especialidadesTableAdapter();
            this.pacientesTableAdapter = new Hospital.hospitalDsTableAdapters.pacientesTableAdapter();
            this.atencsmedicasTableAdapter = new Hospital.hospitalDsTableAdapters.atencsmedicasTableAdapter();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDatos)).BeginInit();
            this.pnlAtencion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAten)).BeginInit();
            this.pnlMedico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMed)).BeginInit();
            this.pnlPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPac)).BeginInit();
            this.pnlfecha.SuspendLayout();
            this.pnlCitasMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosibfk1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atenmedpacBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atenmedpacBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atenmedpacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDatos.Controls.Add(this.lblDatos);
            this.pnlDatos.Controls.Add(this.pcbDatos);
            this.pnlDatos.Controls.Add(this.lblHospi);
            this.pnlDatos.Location = new System.Drawing.Point(12, 12);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(370, 144);
            this.pnlDatos.TabIndex = 0;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(130, 36);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(196, 76);
            this.lblDatos.TabIndex = 1;
            this.lblDatos.Text = "HOSPITAL GENERAL\r\nC/La Salud nº7 - 13005 - C.R\r\nTlfno- 926 20 00 00\r\nCIF -  A1314" +
    "2342Q";
            // 
            // pcbDatos
            // 
            this.pcbDatos.Image = global::Hospital.Properties.Resources.logoHosp;
            this.pcbDatos.Location = new System.Drawing.Point(17, 27);
            this.pcbDatos.Name = "pcbDatos";
            this.pcbDatos.Size = new System.Drawing.Size(100, 94);
            this.pcbDatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDatos.TabIndex = 2;
            this.pcbDatos.TabStop = false;
            // 
            // lblHospi
            // 
            this.lblHospi.AutoSize = true;
            this.lblHospi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospi.Location = new System.Drawing.Point(4, 5);
            this.lblHospi.Name = "lblHospi";
            this.lblHospi.Size = new System.Drawing.Size(132, 19);
            this.lblHospi.TabIndex = 0;
            this.lblHospi.Text = "Datos del hospital";
            // 
            // pnlAtencion
            // 
            this.pnlAtencion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.pnlAtencion.Controls.Add(this.cmbbNomAten);
            this.pnlAtencion.Controls.Add(this.lblNoIDAten);
            this.pnlAtencion.Controls.Add(this.lblIDAten);
            this.pnlAtencion.Controls.Add(this.dtpFechaAten);
            this.pnlAtencion.Controls.Add(this.btnAnCita);
            this.pnlAtencion.Controls.Add(this.lblPacAten);
            this.pnlAtencion.Controls.Add(this.cmbbPacAten);
            this.pnlAtencion.Controls.Add(this.lblNombreAten);
            this.pnlAtencion.Controls.Add(this.cmbbEspeAten);
            this.pnlAtencion.Controls.Add(this.lblEspeAten);
            this.pnlAtencion.Controls.Add(this.lblFechaAten);
            this.pnlAtencion.Controls.Add(this.pcbAten);
            this.pnlAtencion.Controls.Add(this.lblAten);
            this.pnlAtencion.Location = new System.Drawing.Point(391, 12);
            this.pnlAtencion.Name = "pnlAtencion";
            this.pnlAtencion.Size = new System.Drawing.Size(558, 189);
            this.pnlAtencion.TabIndex = 1;
            // 
            // cmbbNomAten
            // 
            this.cmbbNomAten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.cmbbNomAten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbNomAten.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbbNomAten.FormattingEnabled = true;
            this.cmbbNomAten.Location = new System.Drawing.Point(207, 101);
            this.cmbbNomAten.Name = "cmbbNomAten";
            this.cmbbNomAten.Size = new System.Drawing.Size(121, 23);
            this.cmbbNomAten.TabIndex = 31;
            this.cmbbNomAten.SelectedValueChanged += new System.EventHandler(this.cmbbNomAten_SelectedValueChanged);
            // 
            // lblNoIDAten
            // 
            this.lblNoIDAten.AutoSize = true;
            this.lblNoIDAten.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoIDAten.Location = new System.Drawing.Point(223, 39);
            this.lblNoIDAten.Name = "lblNoIDAten";
            this.lblNoIDAten.Size = new System.Drawing.Size(15, 18);
            this.lblNoIDAten.TabIndex = 24;
            this.lblNoIDAten.Text = "0";
            // 
            // lblIDAten
            // 
            this.lblIDAten.AutoSize = true;
            this.lblIDAten.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDAten.Location = new System.Drawing.Point(131, 39);
            this.lblIDAten.Name = "lblIDAten";
            this.lblIDAten.Size = new System.Drawing.Size(84, 18);
            this.lblIDAten.TabIndex = 23;
            this.lblIDAten.Text = "ID Atención:";
            // 
            // dtpFechaAten
            // 
            this.dtpFechaAten.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.dtpFechaAten.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtpFechaAten.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAten.Location = new System.Drawing.Point(204, 63);
            this.dtpFechaAten.Name = "dtpFechaAten";
            this.dtpFechaAten.Size = new System.Drawing.Size(121, 23);
            this.dtpFechaAten.TabIndex = 0;
            // 
            // btnAnCita
            // 
            this.btnAnCita.BackColor = System.Drawing.Color.Yellow;
            this.btnAnCita.FlatAppearance.BorderSize = 0;
            this.btnAnCita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.btnAnCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btnAnCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnCita.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAnCita.Location = new System.Drawing.Point(231, 143);
            this.btnAnCita.Name = "btnAnCita";
            this.btnAnCita.Size = new System.Drawing.Size(198, 28);
            this.btnAnCita.TabIndex = 14;
            this.btnAnCita.Text = "Añadir Cita";
            this.btnAnCita.UseVisualStyleBackColor = false;
            this.btnAnCita.Click += new System.EventHandler(this.btnAnCita_Click);
            // 
            // lblPacAten
            // 
            this.lblPacAten.AutoSize = true;
            this.lblPacAten.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacAten.Location = new System.Drawing.Point(340, 101);
            this.lblPacAten.Name = "lblPacAten";
            this.lblPacAten.Size = new System.Drawing.Size(66, 18);
            this.lblPacAten.TabIndex = 22;
            this.lblPacAten.Text = "Paciente:";
            // 
            // cmbbPacAten
            // 
            this.cmbbPacAten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.cmbbPacAten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbPacAten.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbbPacAten.FormattingEnabled = true;
            this.cmbbPacAten.Location = new System.Drawing.Point(435, 100);
            this.cmbbPacAten.Name = "cmbbPacAten";
            this.cmbbPacAten.Size = new System.Drawing.Size(110, 23);
            this.cmbbPacAten.TabIndex = 21;
            this.cmbbPacAten.SelectedValueChanged += new System.EventHandler(this.cmbbPacAten_SelectedValueChanged);
            // 
            // lblNombreAten
            // 
            this.lblNombreAten.AutoSize = true;
            this.lblNombreAten.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAten.Location = new System.Drawing.Point(134, 105);
            this.lblNombreAten.Name = "lblNombreAten";
            this.lblNombreAten.Size = new System.Drawing.Size(63, 18);
            this.lblNombreAten.TabIndex = 20;
            this.lblNombreAten.Text = "Nombre:";
            // 
            // cmbbEspeAten
            // 
            this.cmbbEspeAten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.cmbbEspeAten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbEspeAten.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbbEspeAten.FormattingEnabled = true;
            this.cmbbEspeAten.Location = new System.Drawing.Point(435, 66);
            this.cmbbEspeAten.Name = "cmbbEspeAten";
            this.cmbbEspeAten.Size = new System.Drawing.Size(110, 23);
            this.cmbbEspeAten.TabIndex = 17;
            this.cmbbEspeAten.SelectedValueChanged += new System.EventHandler(this.cmbbEspeAten_SelectedValueChanged);
            // 
            // lblEspeAten
            // 
            this.lblEspeAten.AutoSize = true;
            this.lblEspeAten.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspeAten.Location = new System.Drawing.Point(340, 67);
            this.lblEspeAten.Name = "lblEspeAten";
            this.lblEspeAten.Size = new System.Drawing.Size(89, 18);
            this.lblEspeAten.TabIndex = 18;
            this.lblEspeAten.Text = "Especialidad:";
            // 
            // lblFechaAten
            // 
            this.lblFechaAten.AutoSize = true;
            this.lblFechaAten.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAten.Location = new System.Drawing.Point(134, 67);
            this.lblFechaAten.Name = "lblFechaAten";
            this.lblFechaAten.Size = new System.Drawing.Size(48, 18);
            this.lblFechaAten.TabIndex = 16;
            this.lblFechaAten.Text = "Fecha:";
            // 
            // pcbAten
            // 
            this.pcbAten.Image = global::Hospital.Properties.Resources.citaMedica;
            this.pcbAten.Location = new System.Drawing.Point(13, 39);
            this.pcbAten.Name = "pcbAten";
            this.pcbAten.Size = new System.Drawing.Size(112, 132);
            this.pcbAten.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAten.TabIndex = 14;
            this.pcbAten.TabStop = false;
            // 
            // lblAten
            // 
            this.lblAten.AutoSize = true;
            this.lblAten.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAten.Location = new System.Drawing.Point(9, 17);
            this.lblAten.Name = "lblAten";
            this.lblAten.Size = new System.Drawing.Size(173, 19);
            this.lblAten.TabIndex = 14;
            this.lblAten.Text = "Nueva Atención Médica";
            // 
            // pnlMedico
            // 
            this.pnlMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.pnlMedico.Controls.Add(this.lblNoIDMed);
            this.pnlMedico.Controls.Add(this.txtNomMed);
            this.pnlMedico.Controls.Add(this.txtEspeMed);
            this.pnlMedico.Controls.Add(this.btnGesMed);
            this.pnlMedico.Controls.Add(this.txtMovMed);
            this.pnlMedico.Controls.Add(this.lblEspeMed);
            this.pnlMedico.Controls.Add(this.txtApellMed);
            this.pnlMedico.Controls.Add(this.lblMovilMed);
            this.pnlMedico.Controls.Add(this.lblApellMed);
            this.pnlMedico.Controls.Add(this.lblNombreMed);
            this.pnlMedico.Controls.Add(this.lblIDMed);
            this.pnlMedico.Controls.Add(this.lblMedico);
            this.pnlMedico.Controls.Add(this.pcbMed);
            this.pnlMedico.Location = new System.Drawing.Point(12, 162);
            this.pnlMedico.Name = "pnlMedico";
            this.pnlMedico.Size = new System.Drawing.Size(370, 223);
            this.pnlMedico.TabIndex = 2;
            // 
            // lblNoIDMed
            // 
            this.lblNoIDMed.AutoSize = true;
            this.lblNoIDMed.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoIDMed.Location = new System.Drawing.Point(223, 20);
            this.lblNoIDMed.Name = "lblNoIDMed";
            this.lblNoIDMed.Size = new System.Drawing.Size(15, 18);
            this.lblNoIDMed.TabIndex = 25;
            this.lblNoIDMed.Text = "0";
            this.lblNoIDMed.TextChanged += new System.EventHandler(this.lblNoIDMed_TextChanged);
            // 
            // txtNomMed
            // 
            this.txtNomMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtNomMed.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomMed.Location = new System.Drawing.Point(225, 42);
            this.txtNomMed.Name = "txtNomMed";
            this.txtNomMed.ReadOnly = true;
            this.txtNomMed.Size = new System.Drawing.Size(122, 23);
            this.txtNomMed.TabIndex = 24;
            // 
            // txtEspeMed
            // 
            this.txtEspeMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtEspeMed.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspeMed.Location = new System.Drawing.Point(225, 129);
            this.txtEspeMed.Name = "txtEspeMed";
            this.txtEspeMed.ReadOnly = true;
            this.txtEspeMed.Size = new System.Drawing.Size(122, 23);
            this.txtEspeMed.TabIndex = 27;
            // 
            // btnGesMed
            // 
            this.btnGesMed.BackColor = System.Drawing.Color.Yellow;
            this.btnGesMed.FlatAppearance.BorderSize = 0;
            this.btnGesMed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.btnGesMed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btnGesMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGesMed.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGesMed.Location = new System.Drawing.Point(77, 180);
            this.btnGesMed.Name = "btnGesMed";
            this.btnGesMed.Size = new System.Drawing.Size(205, 28);
            this.btnGesMed.TabIndex = 13;
            this.btnGesMed.Text = "Gestión de médicos";
            this.btnGesMed.UseVisualStyleBackColor = false;
            this.btnGesMed.Click += new System.EventHandler(this.btnGesMed_Click);
            // 
            // txtMovMed
            // 
            this.txtMovMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtMovMed.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovMed.Location = new System.Drawing.Point(225, 100);
            this.txtMovMed.Name = "txtMovMed";
            this.txtMovMed.ReadOnly = true;
            this.txtMovMed.Size = new System.Drawing.Size(122, 23);
            this.txtMovMed.TabIndex = 26;
            // 
            // lblEspeMed
            // 
            this.lblEspeMed.AutoSize = true;
            this.lblEspeMed.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspeMed.Location = new System.Drawing.Point(135, 130);
            this.lblEspeMed.Name = "lblEspeMed";
            this.lblEspeMed.Size = new System.Drawing.Size(89, 18);
            this.lblEspeMed.TabIndex = 11;
            this.lblEspeMed.Text = "Especialidad:";
            // 
            // txtApellMed
            // 
            this.txtApellMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtApellMed.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellMed.Location = new System.Drawing.Point(225, 71);
            this.txtApellMed.Name = "txtApellMed";
            this.txtApellMed.ReadOnly = true;
            this.txtApellMed.Size = new System.Drawing.Size(122, 23);
            this.txtApellMed.TabIndex = 25;
            // 
            // lblMovilMed
            // 
            this.lblMovilMed.AutoSize = true;
            this.lblMovilMed.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovilMed.Location = new System.Drawing.Point(135, 101);
            this.lblMovilMed.Name = "lblMovilMed";
            this.lblMovilMed.Size = new System.Drawing.Size(48, 18);
            this.lblMovilMed.TabIndex = 7;
            this.lblMovilMed.Text = "Movil:";
            // 
            // lblApellMed
            // 
            this.lblApellMed.AutoSize = true;
            this.lblApellMed.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellMed.Location = new System.Drawing.Point(135, 72);
            this.lblApellMed.Name = "lblApellMed";
            this.lblApellMed.Size = new System.Drawing.Size(71, 18);
            this.lblApellMed.TabIndex = 6;
            this.lblApellMed.Text = "Apellidos:";
            // 
            // lblNombreMed
            // 
            this.lblNombreMed.AutoSize = true;
            this.lblNombreMed.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMed.Location = new System.Drawing.Point(135, 43);
            this.lblNombreMed.Name = "lblNombreMed";
            this.lblNombreMed.Size = new System.Drawing.Size(63, 18);
            this.lblNombreMed.TabIndex = 5;
            this.lblNombreMed.Text = "Nombre:";
            // 
            // lblIDMed
            // 
            this.lblIDMed.AutoSize = true;
            this.lblIDMed.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDMed.Location = new System.Drawing.Point(135, 21);
            this.lblIDMed.Name = "lblIDMed";
            this.lblIDMed.Size = new System.Drawing.Size(75, 18);
            this.lblIDMed.TabIndex = 3;
            this.lblIDMed.Text = "ID Médico:";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.Location = new System.Drawing.Point(13, 20);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(60, 19);
            this.lblMedico.TabIndex = 3;
            this.lblMedico.Text = "Médico";
            // 
            // pcbMed
            // 
            this.pcbMed.Image = global::Hospital.Properties.Resources.medicos;
            this.pcbMed.Location = new System.Drawing.Point(17, 42);
            this.pcbMed.Name = "pcbMed";
            this.pcbMed.Size = new System.Drawing.Size(112, 122);
            this.pcbMed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMed.TabIndex = 0;
            this.pcbMed.TabStop = false;
            // 
            // pnlPaciente
            // 
            this.pnlPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.pnlPaciente.Controls.Add(this.lblNoIDPac);
            this.pnlPaciente.Controls.Add(this.btnGesPac);
            this.pnlPaciente.Controls.Add(this.txtADesPac);
            this.pnlPaciente.Controls.Add(this.lblAlerPac);
            this.pnlPaciente.Controls.Add(this.txtAlerPac);
            this.pnlPaciente.Controls.Add(this.lblADesPac);
            this.pnlPaciente.Controls.Add(this.lblIDPac);
            this.pnlPaciente.Controls.Add(this.txtLocPac);
            this.pnlPaciente.Controls.Add(this.pcbPac);
            this.pnlPaciente.Controls.Add(this.txtApellPac);
            this.pnlPaciente.Controls.Add(this.lblPaciente);
            this.pnlPaciente.Controls.Add(this.txtNomPac);
            this.pnlPaciente.Controls.Add(this.lblNomPac);
            this.pnlPaciente.Controls.Add(this.lblLocPac);
            this.pnlPaciente.Controls.Add(this.lblApellPac);
            this.pnlPaciente.Location = new System.Drawing.Point(12, 392);
            this.pnlPaciente.Name = "pnlPaciente";
            this.pnlPaciente.Size = new System.Drawing.Size(371, 294);
            this.pnlPaciente.TabIndex = 3;
            // 
            // lblNoIDPac
            // 
            this.lblNoIDPac.AutoSize = true;
            this.lblNoIDPac.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblNoIDPac.Location = new System.Drawing.Point(215, 36);
            this.lblNoIDPac.Name = "lblNoIDPac";
            this.lblNoIDPac.Size = new System.Drawing.Size(15, 18);
            this.lblNoIDPac.TabIndex = 24;
            this.lblNoIDPac.Text = "0";
            // 
            // btnGesPac
            // 
            this.btnGesPac.BackColor = System.Drawing.Color.Yellow;
            this.btnGesPac.FlatAppearance.BorderSize = 0;
            this.btnGesPac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.btnGesPac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btnGesPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGesPac.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGesPac.Location = new System.Drawing.Point(17, 180);
            this.btnGesPac.Name = "btnGesPac";
            this.btnGesPac.Size = new System.Drawing.Size(102, 67);
            this.btnGesPac.TabIndex = 14;
            this.btnGesPac.Text = "Gestión de Pacientes";
            this.btnGesPac.UseVisualStyleBackColor = false;
            this.btnGesPac.Click += new System.EventHandler(this.btnGesPac_Click);
            // 
            // txtADesPac
            // 
            this.txtADesPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtADesPac.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADesPac.Location = new System.Drawing.Point(219, 229);
            this.txtADesPac.Multiline = true;
            this.txtADesPac.Name = "txtADesPac";
            this.txtADesPac.ReadOnly = true;
            this.txtADesPac.Size = new System.Drawing.Size(122, 55);
            this.txtADesPac.TabIndex = 23;
            // 
            // lblAlerPac
            // 
            this.lblAlerPac.AutoSize = true;
            this.lblAlerPac.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerPac.Location = new System.Drawing.Point(136, 159);
            this.lblAlerPac.Name = "lblAlerPac";
            this.lblAlerPac.Size = new System.Drawing.Size(62, 18);
            this.lblAlerPac.TabIndex = 22;
            this.lblAlerPac.Text = "Alergias:";
            // 
            // txtAlerPac
            // 
            this.txtAlerPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtAlerPac.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlerPac.Location = new System.Drawing.Point(219, 159);
            this.txtAlerPac.Multiline = true;
            this.txtAlerPac.Name = "txtAlerPac";
            this.txtAlerPac.ReadOnly = true;
            this.txtAlerPac.Size = new System.Drawing.Size(122, 55);
            this.txtAlerPac.TabIndex = 21;
            // 
            // lblADesPac
            // 
            this.lblADesPac.AutoSize = true;
            this.lblADesPac.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADesPac.Location = new System.Drawing.Point(136, 229);
            this.lblADesPac.Name = "lblADesPac";
            this.lblADesPac.Size = new System.Drawing.Size(77, 18);
            this.lblADesPac.TabIndex = 20;
            this.lblADesPac.Text = "A Destacar:";
            // 
            // lblIDPac
            // 
            this.lblIDPac.AutoSize = true;
            this.lblIDPac.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDPac.Location = new System.Drawing.Point(123, 36);
            this.lblIDPac.Name = "lblIDPac";
            this.lblIDPac.Size = new System.Drawing.Size(82, 18);
            this.lblIDPac.TabIndex = 14;
            this.lblIDPac.Text = "ID Paciente:";
            // 
            // txtLocPac
            // 
            this.txtLocPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtLocPac.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocPac.Location = new System.Drawing.Point(218, 122);
            this.txtLocPac.Name = "txtLocPac";
            this.txtLocPac.ReadOnly = true;
            this.txtLocPac.Size = new System.Drawing.Size(122, 23);
            this.txtLocPac.TabIndex = 19;
            // 
            // pcbPac
            // 
            this.pcbPac.Image = global::Hospital.Properties.Resources.enfermo;
            this.pcbPac.Location = new System.Drawing.Point(17, 41);
            this.pcbPac.Name = "pcbPac";
            this.pcbPac.Size = new System.Drawing.Size(100, 122);
            this.pcbPac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPac.TabIndex = 3;
            this.pcbPac.TabStop = false;
            // 
            // txtApellPac
            // 
            this.txtApellPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtApellPac.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellPac.Location = new System.Drawing.Point(218, 93);
            this.txtApellPac.Name = "txtApellPac";
            this.txtApellPac.ReadOnly = true;
            this.txtApellPac.Size = new System.Drawing.Size(122, 23);
            this.txtApellPac.TabIndex = 18;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(13, 17);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(68, 19);
            this.lblPaciente.TabIndex = 14;
            this.lblPaciente.Text = "Paciente";
            // 
            // txtNomPac
            // 
            this.txtNomPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtNomPac.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomPac.Location = new System.Drawing.Point(218, 64);
            this.txtNomPac.Name = "txtNomPac";
            this.txtNomPac.ReadOnly = true;
            this.txtNomPac.Size = new System.Drawing.Size(122, 23);
            this.txtNomPac.TabIndex = 17;
            // 
            // lblNomPac
            // 
            this.lblNomPac.AutoSize = true;
            this.lblNomPac.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPac.Location = new System.Drawing.Point(123, 65);
            this.lblNomPac.Name = "lblNomPac";
            this.lblNomPac.Size = new System.Drawing.Size(63, 18);
            this.lblNomPac.TabIndex = 14;
            this.lblNomPac.Text = "Nombre:";
            // 
            // lblLocPac
            // 
            this.lblLocPac.AutoSize = true;
            this.lblLocPac.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocPac.Location = new System.Drawing.Point(123, 123);
            this.lblLocPac.Name = "lblLocPac";
            this.lblLocPac.Size = new System.Drawing.Size(70, 18);
            this.lblLocPac.TabIndex = 16;
            this.lblLocPac.Text = "Localidad:";
            // 
            // lblApellPac
            // 
            this.lblApellPac.AutoSize = true;
            this.lblApellPac.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellPac.Location = new System.Drawing.Point(123, 94);
            this.lblApellPac.Name = "lblApellPac";
            this.lblApellPac.Size = new System.Drawing.Size(71, 18);
            this.lblApellPac.TabIndex = 15;
            this.lblApellPac.Text = "Apellidos:";
            // 
            // pnlfecha
            // 
            this.pnlfecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.pnlfecha.Controls.Add(this.lblHora);
            this.pnlfecha.Controls.Add(this.lblFecha);
            this.pnlfecha.Location = new System.Drawing.Point(461, 216);
            this.pnlfecha.Name = "pnlfecha";
            this.pnlfecha.Size = new System.Drawing.Size(238, 51);
            this.pnlfecha.TabIndex = 4;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(141, 13);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(82, 24);
            this.lblHora.TabIndex = 26;
            this.lblHora.Text = "00:00:00";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(13, 13);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(108, 24);
            this.lblFecha.TabIndex = 25;
            this.lblFecha.Text = "00/00/0000";
            // 
            // pnlCitasMed
            // 
            this.pnlCitasMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.pnlCitasMed.Controls.Add(this.dgvCitas);
            this.pnlCitasMed.Controls.Add(this.btnActMedCita);
            this.pnlCitasMed.Controls.Add(this.lblNoIDMedCita);
            this.pnlCitasMed.Controls.Add(this.lblIDMedCita);
            this.pnlCitasMed.Controls.Add(this.lblNomEspeCita);
            this.pnlCitasMed.Controls.Add(this.lblEspeCita);
            this.pnlCitasMed.Controls.Add(this.cmbbMedCita);
            this.pnlCitasMed.Controls.Add(this.pcbCita);
            this.pnlCitasMed.Controls.Add(this.lblMedCita);
            this.pnlCitasMed.Controls.Add(this.lblCitas);
            this.pnlCitasMed.Location = new System.Drawing.Point(389, 281);
            this.pnlCitasMed.Name = "pnlCitasMed";
            this.pnlCitasMed.Size = new System.Drawing.Size(560, 405);
            this.pnlCitasMed.TabIndex = 4;
            // 
            // dgvCitas
            // 
            this.dgvCitas.AllowUserToAddRows = false;
            this.dgvCitas.AllowUserToDeleteRows = false;
            this.dgvCitas.AllowUserToOrderColumns = true;
            this.dgvCitas.AllowUserToResizeColumns = false;
            this.dgvCitas.AllowUserToResizeRows = false;
            this.dgvCitas.AutoGenerateColumns = false;
            this.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idatencDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.apellidosDataGridViewTextBoxColumn,
            this.diagnosticoDataGridViewTextBoxColumn});
            this.dgvCitas.DataSource = this.atenmedpacBindingSource2;
            this.dgvCitas.Location = new System.Drawing.Point(31, 134);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.Size = new System.Drawing.Size(499, 261);
            this.dgvCitas.TabIndex = 30;
            // 
            // btnActMedCita
            // 
            this.btnActMedCita.BackColor = System.Drawing.Color.Yellow;
            this.btnActMedCita.FlatAppearance.BorderSize = 0;
            this.btnActMedCita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.btnActMedCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btnActMedCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActMedCita.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnActMedCita.Location = new System.Drawing.Point(359, 81);
            this.btnActMedCita.Name = "btnActMedCita";
            this.btnActMedCita.Size = new System.Drawing.Size(168, 28);
            this.btnActMedCita.TabIndex = 25;
            this.btnActMedCita.Text = "Actualizar Diagnóstico";
            this.btnActMedCita.UseVisualStyleBackColor = false;
            // 
            // lblNoIDMedCita
            // 
            this.lblNoIDMedCita.AutoSize = true;
            this.lblNoIDMedCita.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoIDMedCita.Location = new System.Drawing.Point(437, 45);
            this.lblNoIDMedCita.Name = "lblNoIDMedCita";
            this.lblNoIDMedCita.Size = new System.Drawing.Size(15, 18);
            this.lblNoIDMedCita.TabIndex = 29;
            this.lblNoIDMedCita.Text = "0";
            // 
            // lblIDMedCita
            // 
            this.lblIDMedCita.AutoSize = true;
            this.lblIDMedCita.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDMedCita.Location = new System.Drawing.Point(356, 45);
            this.lblIDMedCita.Name = "lblIDMedCita";
            this.lblIDMedCita.Size = new System.Drawing.Size(75, 18);
            this.lblIDMedCita.TabIndex = 28;
            this.lblIDMedCita.Text = "ID Médico:";
            // 
            // lblNomEspeCita
            // 
            this.lblNomEspeCita.AutoSize = true;
            this.lblNomEspeCita.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEspeCita.Location = new System.Drawing.Point(221, 86);
            this.lblNomEspeCita.Name = "lblNomEspeCita";
            this.lblNomEspeCita.Size = new System.Drawing.Size(16, 18);
            this.lblNomEspeCita.TabIndex = 27;
            this.lblNomEspeCita.Text = "e";
            // 
            // lblEspeCita
            // 
            this.lblEspeCita.AutoSize = true;
            this.lblEspeCita.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspeCita.Location = new System.Drawing.Point(133, 86);
            this.lblEspeCita.Name = "lblEspeCita";
            this.lblEspeCita.Size = new System.Drawing.Size(89, 18);
            this.lblEspeCita.TabIndex = 26;
            this.lblEspeCita.Text = "Especialidad:";
            // 
            // cmbbMedCita
            // 
            this.cmbbMedCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.cmbbMedCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbMedCita.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbbMedCita.FormattingEnabled = true;
            this.cmbbMedCita.Location = new System.Drawing.Point(224, 44);
            this.cmbbMedCita.Name = "cmbbMedCita";
            this.cmbbMedCita.Size = new System.Drawing.Size(121, 23);
            this.cmbbMedCita.TabIndex = 14;
            this.cmbbMedCita.SelectedValueChanged += new System.EventHandler(this.cmbbMedCita_SelectedValueChanged);
            // 
            // pcbCita
            // 
            this.pcbCita.Image = global::Hospital.Properties.Resources.listado;
            this.pcbCita.Location = new System.Drawing.Point(31, 45);
            this.pcbCita.Name = "pcbCita";
            this.pcbCita.Size = new System.Drawing.Size(85, 82);
            this.pcbCita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCita.TabIndex = 25;
            this.pcbCita.TabStop = false;
            // 
            // lblMedCita
            // 
            this.lblMedCita.AutoSize = true;
            this.lblMedCita.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedCita.Location = new System.Drawing.Point(133, 45);
            this.lblMedCita.Name = "lblMedCita";
            this.lblMedCita.Size = new System.Drawing.Size(59, 18);
            this.lblMedCita.TabIndex = 15;
            this.lblMedCita.Text = "Medico:";
            // 
            // lblCitas
            // 
            this.lblCitas.AutoSize = true;
            this.lblCitas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitas.Location = new System.Drawing.Point(12, 21);
            this.lblCitas.Name = "lblCitas";
            this.lblCitas.Size = new System.Drawing.Size(120, 19);
            this.lblCitas.TabIndex = 24;
            this.lblCitas.Text = "Citas del médico";
            // 
            // btnPacMedDia
            // 
            this.btnPacMedDia.BackColor = System.Drawing.Color.Yellow;
            this.btnPacMedDia.FlatAppearance.BorderSize = 0;
            this.btnPacMedDia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.btnPacMedDia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btnPacMedDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacMedDia.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnPacMedDia.Location = new System.Drawing.Point(705, 213);
            this.btnPacMedDia.Name = "btnPacMedDia";
            this.btnPacMedDia.Size = new System.Drawing.Size(163, 28);
            this.btnPacMedDia.TabIndex = 25;
            this.btnPacMedDia.Text = "Pacientes Medico/Dia";
            this.btnPacMedDia.UseVisualStyleBackColor = false;
            // 
            // btnHisto
            // 
            this.btnHisto.BackColor = System.Drawing.Color.Yellow;
            this.btnHisto.FlatAppearance.BorderSize = 0;
            this.btnHisto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.btnHisto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btnHisto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHisto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnHisto.Location = new System.Drawing.Point(705, 247);
            this.btnHisto.Name = "btnHisto";
            this.btnHisto.Size = new System.Drawing.Size(163, 28);
            this.btnHisto.TabIndex = 26;
            this.btnHisto.Text = "Historial Clínico";
            this.btnHisto.UseVisualStyleBackColor = false;
            // 
            // rljFecha
            // 
            this.rljFecha.Tick += new System.EventHandler(this.rljFecha_Tick);
            // 
            // rljHora
            // 
            this.rljHora.Tick += new System.EventHandler(this.rljHora_Tick);
            // 
            // medicosibfk1BindingSource
            // 
            this.medicosibfk1BindingSource.DataMember = "medicos_ibfk_1";
            this.medicosibfk1BindingSource.DataSource = this.especialidadesBindingSource;
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            this.ofdFoto.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";
            // 
            // idatencDataGridViewTextBoxColumn
            // 
            this.idatencDataGridViewTextBoxColumn.DataPropertyName = "idatenc";
            this.idatencDataGridViewTextBoxColumn.HeaderText = "idatenc";
            this.idatencDataGridViewTextBoxColumn.Name = "idatencDataGridViewTextBoxColumn";
            this.idatencDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diagnosticoDataGridViewTextBoxColumn
            // 
            this.diagnosticoDataGridViewTextBoxColumn.DataPropertyName = "diagnostico";
            this.diagnosticoDataGridViewTextBoxColumn.HeaderText = "diagnostico";
            this.diagnosticoDataGridViewTextBoxColumn.Name = "diagnosticoDataGridViewTextBoxColumn";
            // 
            // atenmedpacBindingSource2
            // 
            this.atenmedpacBindingSource2.DataMember = "atenmedpac";
            this.atenmedpacBindingSource2.DataSource = this.hospitalDs;
            // 
            // hospitalDs
            // 
            this.hospitalDs.DataSetName = "hospitalDs";
            this.hospitalDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // especialidadesBindingSource
            // 
            this.especialidadesBindingSource.DataMember = "especialidades";
            this.especialidadesBindingSource.DataSource = this.hospitalDs;
            // 
            // especialidadesBindingSource1
            // 
            this.especialidadesBindingSource1.DataMember = "especialidades";
            this.especialidadesBindingSource1.DataSource = this.hospitalDs;
            // 
            // atenmedpacBindingSource1
            // 
            this.atenmedpacBindingSource1.DataMember = "atenmedpac";
            this.atenmedpacBindingSource1.DataSource = this.hospitalDs;
            // 
            // atenmedpacBindingSource
            // 
            this.atenmedpacBindingSource.DataMember = "atenmedpac";
            this.atenmedpacBindingSource.DataSource = this.hospitalDs;
            // 
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataMember = "medicos";
            this.medicosBindingSource.DataSource = this.hospitalDs;
            // 
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
            // 
            // atenmedpacTableAdapter
            // 
            this.atenmedpacTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.atencsmedicasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.especialidadesTableAdapter = this.especialidadesTableAdapter;
            this.tableAdapterManager.medicosTableAdapter = this.medicosTableAdapter;
            this.tableAdapterManager.pacientesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hospital.hospitalDsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // especialidadesTableAdapter
            // 
            this.especialidadesTableAdapter.ClearBeforeFill = true;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // atencsmedicasTableAdapter
            // 
            this.atencsmedicasTableAdapter.ClearBeforeFill = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(969, 698);
            this.Controls.Add(this.pnlPaciente);
            this.Controls.Add(this.btnHisto);
            this.Controls.Add(this.btnPacMedDia);
            this.Controls.Add(this.pnlfecha);
            this.Controls.Add(this.pnlCitasMed);
            this.Controls.Add(this.pnlMedico);
            this.Controls.Add(this.pnlAtencion);
            this.Controls.Add(this.pnlDatos);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDatos)).EndInit();
            this.pnlAtencion.ResumeLayout(false);
            this.pnlAtencion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAten)).EndInit();
            this.pnlMedico.ResumeLayout(false);
            this.pnlMedico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMed)).EndInit();
            this.pnlPaciente.ResumeLayout(false);
            this.pnlPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPac)).EndInit();
            this.pnlfecha.ResumeLayout(false);
            this.pnlfecha.PerformLayout();
            this.pnlCitasMed.ResumeLayout(false);
            this.pnlCitasMed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosibfk1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atenmedpacBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atenmedpacBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atenmedpacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblHospi;
        private System.Windows.Forms.Panel pnlAtencion;
        private System.Windows.Forms.Panel pnlMedico;
        private System.Windows.Forms.Panel pnlPaciente;
        private System.Windows.Forms.Panel pnlfecha;
        private System.Windows.Forms.Panel pnlCitasMed;
        private System.Windows.Forms.PictureBox pcbDatos;
        private System.Windows.Forms.Label lblMovilMed;
        private System.Windows.Forms.Label lblApellMed;
        private System.Windows.Forms.Label lblNombreMed;
        private System.Windows.Forms.Label lblIDMed;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.PictureBox pcbMed;
        private System.Windows.Forms.Label lblEspeMed;
        private System.Windows.Forms.Button btnGesMed;
        private System.Windows.Forms.Label lblFechaAten;
        private System.Windows.Forms.PictureBox pcbAten;
        private System.Windows.Forms.Label lblAten;
        private System.Windows.Forms.ComboBox cmbbEspeAten;
        private System.Windows.Forms.Label lblEspeAten;
        private System.Windows.Forms.Label lblNoIDAten;
        private System.Windows.Forms.Label lblIDAten;
        private System.Windows.Forms.DateTimePicker dtpFechaAten;
        private System.Windows.Forms.Button btnAnCita;
        private System.Windows.Forms.Label lblPacAten;
        private System.Windows.Forms.ComboBox cmbbPacAten;
        private System.Windows.Forms.Label lblNombreAten;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnPacMedDia;
        private System.Windows.Forms.Button btnHisto;
        private System.Windows.Forms.TextBox txtLocPac;
        private System.Windows.Forms.PictureBox pcbPac;
        private System.Windows.Forms.TextBox txtApellPac;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.TextBox txtNomPac;
        private System.Windows.Forms.Label lblNomPac;
        private System.Windows.Forms.Label lblLocPac;
        private System.Windows.Forms.Label lblApellPac;
        private System.Windows.Forms.Label lblIDPac;
        private System.Windows.Forms.Button btnGesPac;
        private System.Windows.Forms.TextBox txtADesPac;
        private System.Windows.Forms.Label lblAlerPac;
        private System.Windows.Forms.TextBox txtAlerPac;
        private System.Windows.Forms.Label lblADesPac;
        private System.Windows.Forms.Button btnActMedCita;
        private System.Windows.Forms.Label lblNoIDMedCita;
        private System.Windows.Forms.Label lblIDMedCita;
        private System.Windows.Forms.Label lblNomEspeCita;
        private System.Windows.Forms.Label lblEspeCita;
        private System.Windows.Forms.ComboBox cmbbMedCita;
        private System.Windows.Forms.PictureBox pcbCita;
        private System.Windows.Forms.Label lblMedCita;
        private System.Windows.Forms.Label lblCitas;
        private hospitalDs hospitalDs;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private hospitalDsTableAdapters.medicosTableAdapter medicosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource atenmedpacBindingSource;
        private hospitalDsTableAdapters.atenmedpacTableAdapter atenmedpacTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private hospitalDsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Timer rljFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer rljHora;
        private hospitalDsTableAdapters.especialidadesTableAdapter especialidadesTableAdapter;
        private System.Windows.Forms.BindingSource especialidadesBindingSource;
        private System.Windows.Forms.Label lblNoIDMed;
        private System.Windows.Forms.TextBox txtNomMed;
        private System.Windows.Forms.TextBox txtEspeMed;
        private System.Windows.Forms.TextBox txtMovMed;
        private System.Windows.Forms.TextBox txtApellMed;
        private System.Windows.Forms.ComboBox cmbbNomAten;
        private System.Windows.Forms.BindingSource especialidadesBindingSource1;
        private System.Windows.Forms.BindingSource medicosibfk1BindingSource;
        private hospitalDsTableAdapters.pacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.BindingSource atenmedpacBindingSource1;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.BindingSource atenmedpacBindingSource2;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idatencDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblNoIDPac;
        private hospitalDsTableAdapters.atencsmedicasTableAdapter atencsmedicasTableAdapter;
    }
}

