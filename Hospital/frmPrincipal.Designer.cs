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
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.pnlAtencion = new System.Windows.Forms.Panel();
            this.pnlMedico = new System.Windows.Forms.Panel();
            this.pnlPaciente = new System.Windows.Forms.Panel();
            this.pnlfecha = new System.Windows.Forms.Panel();
            this.pnlCitasMed = new System.Windows.Forms.Panel();
            this.lblHospi = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.lblIDMed = new System.Windows.Forms.Label();
            this.lblNoID = new System.Windows.Forms.Label();
            this.lblNombreMed = new System.Windows.Forms.Label();
            this.lblApellMed = new System.Windows.Forms.Label();
            this.lblMovilMed = new System.Windows.Forms.Label();
            this.txtNombreMed = new System.Windows.Forms.TextBox();
            this.txtApellMed = new System.Windows.Forms.TextBox();
            this.txtMovilMed = new System.Windows.Forms.TextBox();
            this.lblEspeMed = new System.Windows.Forms.Label();
            this.btnGesMed = new System.Windows.Forms.Button();
            this.cmbbEspeMed = new System.Windows.Forms.ComboBox();
            this.lblAten = new System.Windows.Forms.Label();
            this.lblFechaAten = new System.Windows.Forms.Label();
            this.cmbbEspeAten = new System.Windows.Forms.ComboBox();
            this.lblEspeAten = new System.Windows.Forms.Label();
            this.cmbbNomAten = new System.Windows.Forms.ComboBox();
            this.lblNombreAten = new System.Windows.Forms.Label();
            this.cmbbPacAten = new System.Windows.Forms.ComboBox();
            this.lblPacAten = new System.Windows.Forms.Label();
            this.btnAnCita = new System.Windows.Forms.Button();
            this.dtpFechaAten = new System.Windows.Forms.DateTimePicker();
            this.lblIDAten = new System.Windows.Forms.Label();
            this.lblNoIDAten = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnPacMedDia = new System.Windows.Forms.Button();
            this.btnHisto = new System.Windows.Forms.Button();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.txtLocPac = new System.Windows.Forms.TextBox();
            this.txtApellPac = new System.Windows.Forms.TextBox();
            this.txtNomPac = new System.Windows.Forms.TextBox();
            this.lblLocPac = new System.Windows.Forms.Label();
            this.lblApellPac = new System.Windows.Forms.Label();
            this.lblNomPac = new System.Windows.Forms.Label();
            this.txtIDPac = new System.Windows.Forms.TextBox();
            this.lblIDPac = new System.Windows.Forms.Label();
            this.txtAlerPac = new System.Windows.Forms.TextBox();
            this.lblADesPac = new System.Windows.Forms.Label();
            this.txtADesPac = new System.Windows.Forms.TextBox();
            this.lblAlerPac = new System.Windows.Forms.Label();
            this.btnGesPac = new System.Windows.Forms.Button();
            this.lblCitas = new System.Windows.Forms.Label();
            this.cmbbMedCita = new System.Windows.Forms.ComboBox();
            this.lblMedCita = new System.Windows.Forms.Label();
            this.lblEspeCita = new System.Windows.Forms.Label();
            this.lblNomEspeCita = new System.Windows.Forms.Label();
            this.lblIDMedCita = new System.Windows.Forms.Label();
            this.lblNoIDMedCita = new System.Windows.Forms.Label();
            this.btnActMedCita = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pcbPac = new System.Windows.Forms.PictureBox();
            this.pcbCita = new System.Windows.Forms.PictureBox();
            this.pcbMed = new System.Windows.Forms.PictureBox();
            this.pcbAten = new System.Windows.Forms.PictureBox();
            this.pcbDatos = new System.Windows.Forms.PictureBox();
            this.pnlDatos.SuspendLayout();
            this.pnlAtencion.SuspendLayout();
            this.pnlMedico.SuspendLayout();
            this.pnlPaciente.SuspendLayout();
            this.pnlfecha.SuspendLayout();
            this.pnlCitasMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDatos)).BeginInit();
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
            // pnlAtencion
            // 
            this.pnlAtencion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.pnlAtencion.Controls.Add(this.lblNoIDAten);
            this.pnlAtencion.Controls.Add(this.lblIDAten);
            this.pnlAtencion.Controls.Add(this.dtpFechaAten);
            this.pnlAtencion.Controls.Add(this.btnAnCita);
            this.pnlAtencion.Controls.Add(this.lblPacAten);
            this.pnlAtencion.Controls.Add(this.cmbbPacAten);
            this.pnlAtencion.Controls.Add(this.cmbbNomAten);
            this.pnlAtencion.Controls.Add(this.lblNombreAten);
            this.pnlAtencion.Controls.Add(this.cmbbEspeAten);
            this.pnlAtencion.Controls.Add(this.lblEspeAten);
            this.pnlAtencion.Controls.Add(this.lblFechaAten);
            this.pnlAtencion.Controls.Add(this.pcbAten);
            this.pnlAtencion.Controls.Add(this.lblAten);
            this.pnlAtencion.Location = new System.Drawing.Point(12, 391);
            this.pnlAtencion.Name = "pnlAtencion";
            this.pnlAtencion.Size = new System.Drawing.Size(370, 227);
            this.pnlAtencion.TabIndex = 1;
            // 
            // pnlMedico
            // 
            this.pnlMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.pnlMedico.Controls.Add(this.btnGesMed);
            this.pnlMedico.Controls.Add(this.txtMovilMed);
            this.pnlMedico.Controls.Add(this.cmbbEspeMed);
            this.pnlMedico.Controls.Add(this.txtApellMed);
            this.pnlMedico.Controls.Add(this.txtNombreMed);
            this.pnlMedico.Controls.Add(this.lblEspeMed);
            this.pnlMedico.Controls.Add(this.lblMovilMed);
            this.pnlMedico.Controls.Add(this.lblApellMed);
            this.pnlMedico.Controls.Add(this.lblNombreMed);
            this.pnlMedico.Controls.Add(this.lblNoID);
            this.pnlMedico.Controls.Add(this.lblIDMed);
            this.pnlMedico.Controls.Add(this.lblMedico);
            this.pnlMedico.Controls.Add(this.pcbMed);
            this.pnlMedico.Location = new System.Drawing.Point(12, 162);
            this.pnlMedico.Name = "pnlMedico";
            this.pnlMedico.Size = new System.Drawing.Size(370, 223);
            this.pnlMedico.TabIndex = 2;
            // 
            // pnlPaciente
            // 
            this.pnlPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.pnlPaciente.Controls.Add(this.btnGesPac);
            this.pnlPaciente.Controls.Add(this.txtADesPac);
            this.pnlPaciente.Controls.Add(this.lblAlerPac);
            this.pnlPaciente.Controls.Add(this.txtAlerPac);
            this.pnlPaciente.Controls.Add(this.lblADesPac);
            this.pnlPaciente.Controls.Add(this.txtIDPac);
            this.pnlPaciente.Controls.Add(this.lblIDPac);
            this.pnlPaciente.Controls.Add(this.txtLocPac);
            this.pnlPaciente.Controls.Add(this.pcbPac);
            this.pnlPaciente.Controls.Add(this.txtApellPac);
            this.pnlPaciente.Controls.Add(this.lblPaciente);
            this.pnlPaciente.Controls.Add(this.txtNomPac);
            this.pnlPaciente.Controls.Add(this.lblNomPac);
            this.pnlPaciente.Controls.Add(this.lblLocPac);
            this.pnlPaciente.Controls.Add(this.lblApellPac);
            this.pnlPaciente.Location = new System.Drawing.Point(388, 12);
            this.pnlPaciente.Name = "pnlPaciente";
            this.pnlPaciente.Size = new System.Drawing.Size(561, 210);
            this.pnlPaciente.TabIndex = 3;
            // 
            // pnlfecha
            // 
            this.pnlfecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.pnlfecha.Controls.Add(this.lblFecha);
            this.pnlfecha.Location = new System.Drawing.Point(461, 234);
            this.pnlfecha.Name = "pnlfecha";
            this.pnlfecha.Size = new System.Drawing.Size(238, 51);
            this.pnlfecha.TabIndex = 4;
            this.pnlfecha.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlfecha_Paint);
            // 
            // pnlCitasMed
            // 
            this.pnlCitasMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.pnlCitasMed.Controls.Add(this.dataGridView1);
            this.pnlCitasMed.Controls.Add(this.btnActMedCita);
            this.pnlCitasMed.Controls.Add(this.lblNoIDMedCita);
            this.pnlCitasMed.Controls.Add(this.lblIDMedCita);
            this.pnlCitasMed.Controls.Add(this.lblNomEspeCita);
            this.pnlCitasMed.Controls.Add(this.lblEspeCita);
            this.pnlCitasMed.Controls.Add(this.cmbbMedCita);
            this.pnlCitasMed.Controls.Add(this.pcbCita);
            this.pnlCitasMed.Controls.Add(this.lblMedCita);
            this.pnlCitasMed.Controls.Add(this.lblCitas);
            this.pnlCitasMed.Location = new System.Drawing.Point(389, 304);
            this.pnlCitasMed.Name = "pnlCitasMed";
            this.pnlCitasMed.Size = new System.Drawing.Size(560, 314);
            this.pnlCitasMed.TabIndex = 4;
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
            // lblNoID
            // 
            this.lblNoID.AutoSize = true;
            this.lblNoID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoID.Location = new System.Drawing.Point(227, 21);
            this.lblNoID.Name = "lblNoID";
            this.lblNoID.Size = new System.Drawing.Size(15, 18);
            this.lblNoID.TabIndex = 4;
            this.lblNoID.Text = "0";
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
            // txtNombreMed
            // 
            this.txtNombreMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtNombreMed.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMed.Location = new System.Drawing.Point(230, 42);
            this.txtNombreMed.Name = "txtNombreMed";
            this.txtNombreMed.Size = new System.Drawing.Size(122, 23);
            this.txtNombreMed.TabIndex = 8;
            // 
            // txtApellMed
            // 
            this.txtApellMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtApellMed.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellMed.Location = new System.Drawing.Point(230, 71);
            this.txtApellMed.Name = "txtApellMed";
            this.txtApellMed.Size = new System.Drawing.Size(122, 23);
            this.txtApellMed.TabIndex = 9;
            // 
            // txtMovilMed
            // 
            this.txtMovilMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtMovilMed.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovilMed.Location = new System.Drawing.Point(230, 100);
            this.txtMovilMed.Name = "txtMovilMed";
            this.txtMovilMed.Size = new System.Drawing.Size(122, 23);
            this.txtMovilMed.TabIndex = 10;
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
            // 
            // cmbbEspeMed
            // 
            this.cmbbEspeMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.cmbbEspeMed.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbbEspeMed.FormattingEnabled = true;
            this.cmbbEspeMed.Location = new System.Drawing.Point(230, 129);
            this.cmbbEspeMed.Name = "cmbbEspeMed";
            this.cmbbEspeMed.Size = new System.Drawing.Size(121, 23);
            this.cmbbEspeMed.TabIndex = 0;
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
            // cmbbEspeAten
            // 
            this.cmbbEspeAten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.cmbbEspeAten.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbbEspeAten.FormattingEnabled = true;
            this.cmbbEspeAten.Location = new System.Drawing.Point(226, 95);
            this.cmbbEspeAten.Name = "cmbbEspeAten";
            this.cmbbEspeAten.Size = new System.Drawing.Size(121, 23);
            this.cmbbEspeAten.TabIndex = 17;
            this.cmbbEspeAten.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // lblEspeAten
            // 
            this.lblEspeAten.AutoSize = true;
            this.lblEspeAten.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspeAten.Location = new System.Drawing.Point(131, 96);
            this.lblEspeAten.Name = "lblEspeAten";
            this.lblEspeAten.Size = new System.Drawing.Size(89, 18);
            this.lblEspeAten.TabIndex = 18;
            this.lblEspeAten.Text = "Especialidad:";
            // 
            // cmbbNomAten
            // 
            this.cmbbNomAten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.cmbbNomAten.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbbNomAten.FormattingEnabled = true;
            this.cmbbNomAten.Location = new System.Drawing.Point(226, 124);
            this.cmbbNomAten.Name = "cmbbNomAten";
            this.cmbbNomAten.Size = new System.Drawing.Size(121, 23);
            this.cmbbNomAten.TabIndex = 19;
            // 
            // lblNombreAten
            // 
            this.lblNombreAten.AutoSize = true;
            this.lblNombreAten.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAten.Location = new System.Drawing.Point(131, 124);
            this.lblNombreAten.Name = "lblNombreAten";
            this.lblNombreAten.Size = new System.Drawing.Size(63, 18);
            this.lblNombreAten.TabIndex = 20;
            this.lblNombreAten.Text = "Nombre:";
            // 
            // cmbbPacAten
            // 
            this.cmbbPacAten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.cmbbPacAten.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbbPacAten.FormattingEnabled = true;
            this.cmbbPacAten.Location = new System.Drawing.Point(226, 153);
            this.cmbbPacAten.Name = "cmbbPacAten";
            this.cmbbPacAten.Size = new System.Drawing.Size(121, 23);
            this.cmbbPacAten.TabIndex = 21;
            // 
            // lblPacAten
            // 
            this.lblPacAten.AutoSize = true;
            this.lblPacAten.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacAten.Location = new System.Drawing.Point(131, 154);
            this.lblPacAten.Name = "lblPacAten";
            this.lblPacAten.Size = new System.Drawing.Size(89, 18);
            this.lblPacAten.TabIndex = 22;
            this.lblPacAten.Text = "Especialidad:";
            // 
            // btnAnCita
            // 
            this.btnAnCita.BackColor = System.Drawing.Color.Yellow;
            this.btnAnCita.FlatAppearance.BorderSize = 0;
            this.btnAnCita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.btnAnCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btnAnCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnCita.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAnCita.Location = new System.Drawing.Point(95, 183);
            this.btnAnCita.Name = "btnAnCita";
            this.btnAnCita.Size = new System.Drawing.Size(198, 28);
            this.btnAnCita.TabIndex = 14;
            this.btnAnCita.Text = "Añadir Cita";
            this.btnAnCita.UseVisualStyleBackColor = false;
            // 
            // dtpFechaAten
            // 
            this.dtpFechaAten.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtpFechaAten.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAten.Location = new System.Drawing.Point(226, 67);
            this.dtpFechaAten.Name = "dtpFechaAten";
            this.dtpFechaAten.Size = new System.Drawing.Size(121, 23);
            this.dtpFechaAten.TabIndex = 0;
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
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(30, 13);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(185, 24);
            this.lblFecha.TabIndex = 25;
            this.lblFecha.Text = "00/00/0000 00:00:00";
            // 
            // btnPacMedDia
            // 
            this.btnPacMedDia.BackColor = System.Drawing.Color.Yellow;
            this.btnPacMedDia.FlatAppearance.BorderSize = 0;
            this.btnPacMedDia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.btnPacMedDia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btnPacMedDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacMedDia.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnPacMedDia.Location = new System.Drawing.Point(705, 231);
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
            this.btnHisto.Location = new System.Drawing.Point(705, 265);
            this.btnHisto.Name = "btnHisto";
            this.btnHisto.Size = new System.Drawing.Size(163, 28);
            this.btnHisto.TabIndex = 26;
            this.btnHisto.Text = "Historial Clínico";
            this.btnHisto.UseVisualStyleBackColor = false;
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
            // txtLocPac
            // 
            this.txtLocPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtLocPac.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocPac.Location = new System.Drawing.Point(218, 122);
            this.txtLocPac.Name = "txtLocPac";
            this.txtLocPac.Size = new System.Drawing.Size(122, 23);
            this.txtLocPac.TabIndex = 19;
            // 
            // txtApellPac
            // 
            this.txtApellPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtApellPac.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellPac.Location = new System.Drawing.Point(218, 93);
            this.txtApellPac.Name = "txtApellPac";
            this.txtApellPac.Size = new System.Drawing.Size(122, 23);
            this.txtApellPac.TabIndex = 18;
            // 
            // txtNomPac
            // 
            this.txtNomPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtNomPac.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomPac.Location = new System.Drawing.Point(218, 64);
            this.txtNomPac.Name = "txtNomPac";
            this.txtNomPac.Size = new System.Drawing.Size(122, 23);
            this.txtNomPac.TabIndex = 17;
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
            // txtIDPac
            // 
            this.txtIDPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtIDPac.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPac.Location = new System.Drawing.Point(218, 35);
            this.txtIDPac.Name = "txtIDPac";
            this.txtIDPac.Size = new System.Drawing.Size(122, 23);
            this.txtIDPac.TabIndex = 15;
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
            this.lblIDPac.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtAlerPac
            // 
            this.txtAlerPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtAlerPac.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlerPac.Location = new System.Drawing.Point(429, 36);
            this.txtAlerPac.Multiline = true;
            this.txtAlerPac.Name = "txtAlerPac";
            this.txtAlerPac.Size = new System.Drawing.Size(122, 55);
            this.txtAlerPac.TabIndex = 21;
            // 
            // lblADesPac
            // 
            this.lblADesPac.AutoSize = true;
            this.lblADesPac.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADesPac.Location = new System.Drawing.Point(346, 98);
            this.lblADesPac.Name = "lblADesPac";
            this.lblADesPac.Size = new System.Drawing.Size(77, 18);
            this.lblADesPac.TabIndex = 20;
            this.lblADesPac.Text = "A Destacar:";
            // 
            // txtADesPac
            // 
            this.txtADesPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtADesPac.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADesPac.Location = new System.Drawing.Point(429, 98);
            this.txtADesPac.Multiline = true;
            this.txtADesPac.Name = "txtADesPac";
            this.txtADesPac.Size = new System.Drawing.Size(122, 55);
            this.txtADesPac.TabIndex = 23;
            // 
            // lblAlerPac
            // 
            this.lblAlerPac.AutoSize = true;
            this.lblAlerPac.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerPac.Location = new System.Drawing.Point(346, 36);
            this.lblAlerPac.Name = "lblAlerPac";
            this.lblAlerPac.Size = new System.Drawing.Size(62, 18);
            this.lblAlerPac.TabIndex = 22;
            this.lblAlerPac.Text = "Alergias:";
            // 
            // btnGesPac
            // 
            this.btnGesPac.BackColor = System.Drawing.Color.Yellow;
            this.btnGesPac.FlatAppearance.BorderSize = 0;
            this.btnGesPac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.btnGesPac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btnGesPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGesPac.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGesPac.Location = new System.Drawing.Point(174, 166);
            this.btnGesPac.Name = "btnGesPac";
            this.btnGesPac.Size = new System.Drawing.Size(249, 28);
            this.btnGesPac.TabIndex = 14;
            this.btnGesPac.Text = "Gestión de Pacientes";
            this.btnGesPac.UseVisualStyleBackColor = false;
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
            // cmbbMedCita
            // 
            this.cmbbMedCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.cmbbMedCita.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbbMedCita.FormattingEnabled = true;
            this.cmbbMedCita.Location = new System.Drawing.Point(251, 62);
            this.cmbbMedCita.Name = "cmbbMedCita";
            this.cmbbMedCita.Size = new System.Drawing.Size(121, 23);
            this.cmbbMedCita.TabIndex = 14;
            // 
            // lblMedCita
            // 
            this.lblMedCita.AutoSize = true;
            this.lblMedCita.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedCita.Location = new System.Drawing.Point(148, 63);
            this.lblMedCita.Name = "lblMedCita";
            this.lblMedCita.Size = new System.Drawing.Size(89, 18);
            this.lblMedCita.TabIndex = 15;
            this.lblMedCita.Text = "Especialidad:";
            // 
            // lblEspeCita
            // 
            this.lblEspeCita.AutoSize = true;
            this.lblEspeCita.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspeCita.Location = new System.Drawing.Point(378, 63);
            this.lblEspeCita.Name = "lblEspeCita";
            this.lblEspeCita.Size = new System.Drawing.Size(89, 18);
            this.lblEspeCita.TabIndex = 26;
            this.lblEspeCita.Text = "Especialidad:";
            // 
            // lblNomEspeCita
            // 
            this.lblNomEspeCita.AutoSize = true;
            this.lblNomEspeCita.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEspeCita.Location = new System.Drawing.Point(470, 63);
            this.lblNomEspeCita.Name = "lblNomEspeCita";
            this.lblNomEspeCita.Size = new System.Drawing.Size(60, 18);
            this.lblNomEspeCita.TabIndex = 27;
            this.lblNomEspeCita.Text = "Cirujano";
            // 
            // lblIDMedCita
            // 
            this.lblIDMedCita.AutoSize = true;
            this.lblIDMedCita.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDMedCita.Location = new System.Drawing.Point(148, 104);
            this.lblIDMedCita.Name = "lblIDMedCita";
            this.lblIDMedCita.Size = new System.Drawing.Size(75, 18);
            this.lblIDMedCita.TabIndex = 28;
            this.lblIDMedCita.Text = "ID Médico:";
            // 
            // lblNoIDMedCita
            // 
            this.lblNoIDMedCita.AutoSize = true;
            this.lblNoIDMedCita.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoIDMedCita.Location = new System.Drawing.Point(229, 104);
            this.lblNoIDMedCita.Name = "lblNoIDMedCita";
            this.lblNoIDMedCita.Size = new System.Drawing.Size(15, 18);
            this.lblNoIDMedCita.TabIndex = 29;
            this.lblNoIDMedCita.Text = "0";
            // 
            // btnActMedCita
            // 
            this.btnActMedCita.BackColor = System.Drawing.Color.Yellow;
            this.btnActMedCita.FlatAppearance.BorderSize = 0;
            this.btnActMedCita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.btnActMedCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btnActMedCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActMedCita.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnActMedCita.Location = new System.Drawing.Point(250, 99);
            this.btnActMedCita.Name = "btnActMedCita";
            this.btnActMedCita.Size = new System.Drawing.Size(280, 28);
            this.btnActMedCita.TabIndex = 25;
            this.btnActMedCita.Text = "Actualiza Médicos";
            this.btnActMedCita.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 133);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(530, 165);
            this.dataGridView1.TabIndex = 30;
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
            // pcbMed
            // 
            this.pcbMed.Location = new System.Drawing.Point(17, 42);
            this.pcbMed.Name = "pcbMed";
            this.pcbMed.Size = new System.Drawing.Size(112, 122);
            this.pcbMed.TabIndex = 0;
            this.pcbMed.TabStop = false;
            this.pcbMed.Click += new System.EventHandler(this.pictureBox2_Click);
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
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(969, 631);
            this.Controls.Add(this.pnlPaciente);
            this.Controls.Add(this.btnHisto);
            this.Controls.Add(this.btnPacMedDia);
            this.Controls.Add(this.pnlfecha);
            this.Controls.Add(this.pnlCitasMed);
            this.Controls.Add(this.pnlMedico);
            this.Controls.Add(this.pnlAtencion);
            this.Controls.Add(this.pnlDatos);
            this.Name = "frmPrincipal";
            this.Text = "Hospital";
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.pnlAtencion.ResumeLayout(false);
            this.pnlAtencion.PerformLayout();
            this.pnlMedico.ResumeLayout(false);
            this.pnlMedico.PerformLayout();
            this.pnlPaciente.ResumeLayout(false);
            this.pnlPaciente.PerformLayout();
            this.pnlfecha.ResumeLayout(false);
            this.pnlfecha.PerformLayout();
            this.pnlCitasMed.ResumeLayout(false);
            this.pnlCitasMed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDatos)).EndInit();
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
        private System.Windows.Forms.Label lblNoID;
        private System.Windows.Forms.Label lblIDMed;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.PictureBox pcbMed;
        private System.Windows.Forms.TextBox txtMovilMed;
        private System.Windows.Forms.TextBox txtApellMed;
        private System.Windows.Forms.TextBox txtNombreMed;
        private System.Windows.Forms.Label lblEspeMed;
        private System.Windows.Forms.Button btnGesMed;
        private System.Windows.Forms.Label lblFechaAten;
        private System.Windows.Forms.PictureBox pcbAten;
        private System.Windows.Forms.Label lblAten;
        private System.Windows.Forms.ComboBox cmbbEspeMed;
        private System.Windows.Forms.ComboBox cmbbEspeAten;
        private System.Windows.Forms.Label lblEspeAten;
        private System.Windows.Forms.Label lblNoIDAten;
        private System.Windows.Forms.Label lblIDAten;
        private System.Windows.Forms.DateTimePicker dtpFechaAten;
        private System.Windows.Forms.Button btnAnCita;
        private System.Windows.Forms.Label lblPacAten;
        private System.Windows.Forms.ComboBox cmbbPacAten;
        private System.Windows.Forms.ComboBox cmbbNomAten;
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
        private System.Windows.Forms.TextBox txtIDPac;
        private System.Windows.Forms.Label lblIDPac;
        private System.Windows.Forms.Button btnGesPac;
        private System.Windows.Forms.TextBox txtADesPac;
        private System.Windows.Forms.Label lblAlerPac;
        private System.Windows.Forms.TextBox txtAlerPac;
        private System.Windows.Forms.Label lblADesPac;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnActMedCita;
        private System.Windows.Forms.Label lblNoIDMedCita;
        private System.Windows.Forms.Label lblIDMedCita;
        private System.Windows.Forms.Label lblNomEspeCita;
        private System.Windows.Forms.Label lblEspeCita;
        private System.Windows.Forms.ComboBox cmbbMedCita;
        private System.Windows.Forms.PictureBox pcbCita;
        private System.Windows.Forms.Label lblMedCita;
        private System.Windows.Forms.Label lblCitas;
    }
}

