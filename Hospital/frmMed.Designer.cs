namespace Hospital
{
    partial class frmMed
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
            System.Windows.Forms.Label lblMovil;
            System.Windows.Forms.Label lblApellMed;
            System.Windows.Forms.Label lblEspeMed;
            System.Windows.Forms.Label lblNomMed;
            System.Windows.Forms.Label lblIDMed;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMed));
            this.hospitalDs = new Hospital.hospitalDs();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicosTableAdapter = new Hospital.hospitalDsTableAdapters.medicosTableAdapter();
            this.tableAdapterManager = new Hospital.hospitalDsTableAdapters.TableAdapterManager();
            this.medicosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.medicosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.especialidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.especialidadesTableAdapter = new Hospital.hospitalDsTableAdapters.especialidadesTableAdapter();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.txtApellMed = new System.Windows.Forms.TextBox();
            this.txtMovilMed = new System.Windows.Forms.TextBox();
            this.txtNomMed = new System.Windows.Forms.TextBox();
            this.cmbbEspeMed = new System.Windows.Forms.ComboBox();
            this.lblNoIDMed = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.btnFoto = new System.Windows.Forms.Button();
            this.pcbMed = new System.Windows.Forms.PictureBox();
            lblMovil = new System.Windows.Forms.Label();
            lblApellMed = new System.Windows.Forms.Label();
            lblEspeMed = new System.Windows.Forms.Label();
            lblNomMed = new System.Windows.Forms.Label();
            lblIDMed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingNavigator)).BeginInit();
            this.medicosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMed)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMovil
            // 
            lblMovil.AutoSize = true;
            lblMovil.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            lblMovil.Location = new System.Drawing.Point(144, 146);
            lblMovil.Name = "lblMovil";
            lblMovil.Size = new System.Drawing.Size(47, 18);
            lblMovil.TabIndex = 7;
            lblMovil.Text = "movil:";
            // 
            // lblApellMed
            // 
            lblApellMed.AutoSize = true;
            lblApellMed.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            lblApellMed.Location = new System.Drawing.Point(144, 120);
            lblApellMed.Name = "lblApellMed";
            lblApellMed.Size = new System.Drawing.Size(69, 18);
            lblApellMed.TabIndex = 5;
            lblApellMed.Text = "apellidos:";
            // 
            // lblEspeMed
            // 
            lblEspeMed.AutoSize = true;
            lblEspeMed.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            lblEspeMed.Location = new System.Drawing.Point(144, 172);
            lblEspeMed.Name = "lblEspeMed";
            lblEspeMed.Size = new System.Drawing.Size(90, 18);
            lblEspeMed.TabIndex = 9;
            lblEspeMed.Text = "especialidad:";
            // 
            // lblNomMed
            // 
            lblNomMed.AutoSize = true;
            lblNomMed.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            lblNomMed.Location = new System.Drawing.Point(144, 94);
            lblNomMed.Name = "lblNomMed";
            lblNomMed.Size = new System.Drawing.Size(61, 18);
            lblNomMed.TabIndex = 3;
            lblNomMed.Text = "nombre:";
            // 
            // lblIDMed
            // 
            lblIDMed.AutoSize = true;
            lblIDMed.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            lblIDMed.Location = new System.Drawing.Point(144, 65);
            lblIDMed.Name = "lblIDMed";
            lblIDMed.Size = new System.Drawing.Size(70, 18);
            lblIDMed.TabIndex = 1;
            lblIDMed.Text = "idmedico:";
            // 
            // hospitalDs
            // 
            this.hospitalDs.DataSetName = "hospitalDs";
            this.hospitalDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.atencsmedicasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.especialidadesTableAdapter = null;
            this.tableAdapterManager.medicosTableAdapter = this.medicosTableAdapter;
            this.tableAdapterManager.pacientesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hospital.hospitalDsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // medicosBindingNavigator
            // 
            this.medicosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.medicosBindingNavigator.BackColor = System.Drawing.Color.LightSkyBlue;
            this.medicosBindingNavigator.BindingSource = this.medicosBindingSource;
            this.medicosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medicosBindingNavigator.DeleteItem = null;
            this.medicosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.medicosBindingNavigatorSaveItem});
            this.medicosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.medicosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medicosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medicosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medicosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medicosBindingNavigator.Name = "medicosBindingNavigator";
            this.medicosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medicosBindingNavigator.Size = new System.Drawing.Size(384, 25);
            this.medicosBindingNavigator.TabIndex = 0;
            this.medicosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // medicosBindingNavigatorSaveItem
            // 
            this.medicosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medicosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medicosBindingNavigatorSaveItem.Image")));
            this.medicosBindingNavigatorSaveItem.Name = "medicosBindingNavigatorSaveItem";
            this.medicosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.medicosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.medicosBindingNavigatorSaveItem.Click += new System.EventHandler(this.medicosBindingNavigatorSaveItem_Click);
            // 
            // especialidadesBindingSource
            // 
            this.especialidadesBindingSource.DataMember = "especialidades";
            this.especialidadesBindingSource.DataSource = this.hospitalDs;
            // 
            // especialidadesTableAdapter
            // 
            this.especialidadesTableAdapter.ClearBeforeFill = true;
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "ofdFoto";
            this.ofdFoto.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";
            // 
            // txtApellMed
            // 
            this.txtApellMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtApellMed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "apellidos", true));
            this.txtApellMed.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtApellMed.Location = new System.Drawing.Point(240, 119);
            this.txtApellMed.Name = "txtApellMed";
            this.txtApellMed.Size = new System.Drawing.Size(121, 23);
            this.txtApellMed.TabIndex = 6;
            // 
            // txtMovilMed
            // 
            this.txtMovilMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtMovilMed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "movil", true));
            this.txtMovilMed.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtMovilMed.Location = new System.Drawing.Point(240, 145);
            this.txtMovilMed.Name = "txtMovilMed";
            this.txtMovilMed.Size = new System.Drawing.Size(121, 23);
            this.txtMovilMed.TabIndex = 8;
            // 
            // txtNomMed
            // 
            this.txtNomMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtNomMed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "nombre", true));
            this.txtNomMed.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNomMed.Location = new System.Drawing.Point(240, 93);
            this.txtNomMed.Name = "txtNomMed";
            this.txtNomMed.Size = new System.Drawing.Size(121, 23);
            this.txtNomMed.TabIndex = 4;
            // 
            // cmbbEspeMed
            // 
            this.cmbbEspeMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.cmbbEspeMed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "especialidad", true));
            this.cmbbEspeMed.DataSource = this.especialidadesBindingSource;
            this.cmbbEspeMed.DisplayMember = "especialidad";
            this.cmbbEspeMed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbEspeMed.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbbEspeMed.FormattingEnabled = true;
            this.cmbbEspeMed.Location = new System.Drawing.Point(240, 171);
            this.cmbbEspeMed.Name = "cmbbEspeMed";
            this.cmbbEspeMed.Size = new System.Drawing.Size(121, 23);
            this.cmbbEspeMed.TabIndex = 10;
            // 
            // lblNoIDMed
            // 
            this.lblNoIDMed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "idmedico", true));
            this.lblNoIDMed.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblNoIDMed.Location = new System.Drawing.Point(219, 65);
            this.lblNoIDMed.Name = "lblNoIDMed";
            this.lblNoIDMed.Size = new System.Drawing.Size(121, 23);
            this.lblNoIDMed.TabIndex = 2;
            this.lblNoIDMed.Text = "label1";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.Location = new System.Drawing.Point(12, 38);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(60, 19);
            this.lblMedico.TabIndex = 3;
            this.lblMedico.Text = "Médico";
            this.lblMedico.Click += new System.EventHandler(this.lblMedico_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.Color.Yellow;
            this.btnFoto.FlatAppearance.BorderSize = 0;
            this.btnFoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.btnFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnFoto.Location = new System.Drawing.Point(16, 198);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(112, 28);
            this.btnFoto.TabIndex = 14;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // pcbMed
            // 
            this.pcbMed.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.medicosBindingSource, "foto", true));
            this.pcbMed.Location = new System.Drawing.Point(16, 65);
            this.pcbMed.Name = "pcbMed";
            this.pcbMed.Size = new System.Drawing.Size(112, 122);
            this.pcbMed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMed.TabIndex = 15;
            this.pcbMed.TabStop = false;
            // 
            // frmMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(384, 252);
            this.Controls.Add(this.pcbMed);
            this.Controls.Add(this.medicosBindingNavigator);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(lblIDMed);
            this.Controls.Add(this.txtApellMed);
            this.Controls.Add(this.lblNoIDMed);
            this.Controls.Add(lblMovil);
            this.Controls.Add(this.cmbbEspeMed);
            this.Controls.Add(lblApellMed);
            this.Controls.Add(lblNomMed);
            this.Controls.Add(this.txtMovilMed);
            this.Controls.Add(lblEspeMed);
            this.Controls.Add(this.txtNomMed);
            this.Name = "frmMed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de Medicos";
            this.Load += new System.EventHandler(this.frmMed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingNavigator)).EndInit();
            this.medicosBindingNavigator.ResumeLayout(false);
            this.medicosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private hospitalDs hospitalDs;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private hospitalDsTableAdapters.medicosTableAdapter medicosTableAdapter;
        private hospitalDsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator medicosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton medicosBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource especialidadesBindingSource;
        private hospitalDsTableAdapters.especialidadesTableAdapter especialidadesTableAdapter;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.TextBox txtApellMed;
        private System.Windows.Forms.TextBox txtMovilMed;
        private System.Windows.Forms.TextBox txtNomMed;
        private System.Windows.Forms.ComboBox cmbbEspeMed;
        private System.Windows.Forms.Label lblNoIDMed;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox pcbMed;
    }
}