namespace Hospital
{
    partial class frmHistorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorial));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atenmedpacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDs = new Hospital.hospitalDs();
            this.atenmedpacTableAdapter = new Hospital.hospitalDsTableAdapters.atenmedpacTableAdapter();
            this.lblPacAten = new System.Windows.Forms.Label();
            this.cmbbPacAten = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pacientesTableAdapter = new Hospital.hospitalDsTableAdapters.pacientesTableAdapter();
            this.lblHistorial = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atenmedpacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.expr2DataGridViewTextBoxColumn,
            this.movilDataGridViewTextBoxColumn,
            this.diagnosticoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.atenmedpacBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(776, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Expr1";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expr2DataGridViewTextBoxColumn
            // 
            this.expr2DataGridViewTextBoxColumn.DataPropertyName = "Expr2";
            this.expr2DataGridViewTextBoxColumn.HeaderText = "Expr2";
            this.expr2DataGridViewTextBoxColumn.Name = "expr2DataGridViewTextBoxColumn";
            this.expr2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movilDataGridViewTextBoxColumn
            // 
            this.movilDataGridViewTextBoxColumn.DataPropertyName = "movil";
            this.movilDataGridViewTextBoxColumn.HeaderText = "movil";
            this.movilDataGridViewTextBoxColumn.Name = "movilDataGridViewTextBoxColumn";
            this.movilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diagnosticoDataGridViewTextBoxColumn
            // 
            this.diagnosticoDataGridViewTextBoxColumn.DataPropertyName = "diagnostico";
            this.diagnosticoDataGridViewTextBoxColumn.HeaderText = "diagnostico";
            this.diagnosticoDataGridViewTextBoxColumn.Name = "diagnosticoDataGridViewTextBoxColumn";
            this.diagnosticoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // atenmedpacBindingSource
            // 
            this.atenmedpacBindingSource.DataMember = "atenmedpac";
            this.atenmedpacBindingSource.DataSource = this.hospitalDs;
            // 
            // hospitalDs
            // 
            this.hospitalDs.DataSetName = "hospitalDs";
            this.hospitalDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // atenmedpacTableAdapter
            // 
            this.atenmedpacTableAdapter.ClearBeforeFill = true;
            // 
            // lblPacAten
            // 
            this.lblPacAten.AutoSize = true;
            this.lblPacAten.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacAten.Location = new System.Drawing.Point(163, 69);
            this.lblPacAten.Name = "lblPacAten";
            this.lblPacAten.Size = new System.Drawing.Size(66, 18);
            this.lblPacAten.TabIndex = 24;
            this.lblPacAten.Text = "Paciente:";
            // 
            // cmbbPacAten
            // 
            this.cmbbPacAten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.cmbbPacAten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbPacAten.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbbPacAten.FormattingEnabled = true;
            this.cmbbPacAten.Location = new System.Drawing.Point(258, 68);
            this.cmbbPacAten.Name = "cmbbPacAten";
            this.cmbbPacAten.Size = new System.Drawing.Size(148, 23);
            this.cmbbPacAten.TabIndex = 23;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Yellow;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(433, 68);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(195, 23);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHistorial.Location = new System.Drawing.Point(251, 9);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(297, 42);
            this.lblHistorial.TabIndex = 26;
            this.lblHistorial.Text = "HISTORIAL CLÍNICO";
            this.lblHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblPacAten);
            this.Controls.Add(this.cmbbPacAten);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHistorial";
            this.Text = "frm_historial";
            this.Load += new System.EventHandler(this.frm_historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atenmedpacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private hospitalDs hospitalDs;
        private System.Windows.Forms.BindingSource atenmedpacBindingSource;
        private hospitalDsTableAdapters.atenmedpacTableAdapter atenmedpacTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblPacAten;
        private System.Windows.Forms.ComboBox cmbbPacAten;
        private System.Windows.Forms.Button btnBuscar;
        private hospitalDsTableAdapters.pacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.Label lblHistorial;
    }
}