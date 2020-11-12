namespace Hospital
{
    partial class frmPac
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
            System.Windows.Forms.Label lblIDPac;
            System.Windows.Forms.Label lblNomPac;
            System.Windows.Forms.Label lblApellPac;
            System.Windows.Forms.Label lblLocPac;
            System.Windows.Forms.Label lblAlerPac;
            System.Windows.Forms.Label lblAdesPac;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPac));
            this.hospitalDs = new Hospital.hospitalDs();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesTableAdapter = new Hospital.hospitalDsTableAdapters.pacientesTableAdapter();
            this.tableAdapterManager = new Hospital.hospitalDsTableAdapters.TableAdapterManager();
            this.pacientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pacientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lblNoIDPac = new System.Windows.Forms.Label();
            this.txtApellPac = new System.Windows.Forms.TextBox();
            this.txtNomPac = new System.Windows.Forms.TextBox();
            this.txtLocPac = new System.Windows.Forms.TextBox();
            this.txtAlePac = new System.Windows.Forms.TextBox();
            this.txtAdesPac = new System.Windows.Forms.TextBox();
            lblIDPac = new System.Windows.Forms.Label();
            lblNomPac = new System.Windows.Forms.Label();
            lblApellPac = new System.Windows.Forms.Label();
            lblLocPac = new System.Windows.Forms.Label();
            lblAlerPac = new System.Windows.Forms.Label();
            lblAdesPac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingNavigator)).BeginInit();
            this.pacientesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIDPac
            // 
            lblIDPac.AutoSize = true;
            lblIDPac.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            lblIDPac.Location = new System.Drawing.Point(50, 36);
            lblIDPac.Name = "lblIDPac";
            lblIDPac.Size = new System.Drawing.Size(78, 18);
            lblIDPac.TabIndex = 1;
            lblIDPac.Text = "idpaciente:";
            // 
            // lblNomPac
            // 
            lblNomPac.AutoSize = true;
            lblNomPac.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            lblNomPac.Location = new System.Drawing.Point(50, 92);
            lblNomPac.Name = "lblNomPac";
            lblNomPac.Size = new System.Drawing.Size(61, 18);
            lblNomPac.TabIndex = 3;
            lblNomPac.Text = "nombre:";
            // 
            // lblApellPac
            // 
            lblApellPac.AutoSize = true;
            lblApellPac.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            lblApellPac.Location = new System.Drawing.Point(50, 63);
            lblApellPac.Name = "lblApellPac";
            lblApellPac.Size = new System.Drawing.Size(69, 18);
            lblApellPac.TabIndex = 5;
            lblApellPac.Text = "apellidos:";
            // 
            // lblLocPac
            // 
            lblLocPac.AutoSize = true;
            lblLocPac.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            lblLocPac.Location = new System.Drawing.Point(50, 120);
            lblLocPac.Name = "lblLocPac";
            lblLocPac.Size = new System.Drawing.Size(68, 18);
            lblLocPac.TabIndex = 7;
            lblLocPac.Text = "localidad:";
            // 
            // lblAlerPac
            // 
            lblAlerPac.AutoSize = true;
            lblAlerPac.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            lblAlerPac.Location = new System.Drawing.Point(50, 148);
            lblAlerPac.Name = "lblAlerPac";
            lblAlerPac.Size = new System.Drawing.Size(60, 18);
            lblAlerPac.TabIndex = 9;
            lblAlerPac.Text = "alergias:";
            // 
            // lblAdesPac
            // 
            lblAdesPac.AutoSize = true;
            lblAdesPac.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            lblAdesPac.Location = new System.Drawing.Point(50, 196);
            lblAdesPac.Name = "lblAdesPac";
            lblAdesPac.Size = new System.Drawing.Size(71, 18);
            lblAdesPac.TabIndex = 11;
            lblAdesPac.Text = "adestacar:";
            // 
            // hospitalDs
            // 
            this.hospitalDs.DataSetName = "hospitalDs";
            this.hospitalDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "pacientes";
            this.pacientesBindingSource.DataSource = this.hospitalDs;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.atencsmedicasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.especialidadesTableAdapter = null;
            this.tableAdapterManager.medicosTableAdapter = null;
            this.tableAdapterManager.pacientesTableAdapter = this.pacientesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Hospital.hospitalDsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pacientesBindingNavigator
            // 
            this.pacientesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pacientesBindingNavigator.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pacientesBindingNavigator.BindingSource = this.pacientesBindingSource;
            this.pacientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pacientesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pacientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pacientesBindingNavigatorSaveItem});
            this.pacientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pacientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pacientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pacientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pacientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pacientesBindingNavigator.Name = "pacientesBindingNavigator";
            this.pacientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pacientesBindingNavigator.Size = new System.Drawing.Size(384, 25);
            this.pacientesBindingNavigator.TabIndex = 0;
            this.pacientesBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
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
            // pacientesBindingNavigatorSaveItem
            // 
            this.pacientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pacientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pacientesBindingNavigatorSaveItem.Image")));
            this.pacientesBindingNavigatorSaveItem.Name = "pacientesBindingNavigatorSaveItem";
            this.pacientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pacientesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.pacientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.pacientesBindingNavigatorSaveItem_Click);
            // 
            // lblNoIDPac
            // 
            this.lblNoIDPac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "idpaciente", true));
            this.lblNoIDPac.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblNoIDPac.Location = new System.Drawing.Point(144, 36);
            this.lblNoIDPac.Name = "lblNoIDPac";
            this.lblNoIDPac.Size = new System.Drawing.Size(100, 23);
            this.lblNoIDPac.TabIndex = 2;
            this.lblNoIDPac.Text = "label1";
            // 
            // txtApellPac
            // 
            this.txtApellPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtApellPac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "nombre", true));
            this.txtApellPac.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtApellPac.Location = new System.Drawing.Point(147, 62);
            this.txtApellPac.Name = "txtApellPac";
            this.txtApellPac.Size = new System.Drawing.Size(189, 23);
            this.txtApellPac.TabIndex = 4;
            // 
            // txtNomPac
            // 
            this.txtNomPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtNomPac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "apellidos", true));
            this.txtNomPac.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNomPac.Location = new System.Drawing.Point(147, 91);
            this.txtNomPac.Name = "txtNomPac";
            this.txtNomPac.Size = new System.Drawing.Size(189, 23);
            this.txtNomPac.TabIndex = 6;
            // 
            // txtLocPac
            // 
            this.txtLocPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtLocPac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "localidad", true));
            this.txtLocPac.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtLocPac.Location = new System.Drawing.Point(147, 119);
            this.txtLocPac.Name = "txtLocPac";
            this.txtLocPac.Size = new System.Drawing.Size(189, 23);
            this.txtLocPac.TabIndex = 8;
            // 
            // txtAlePac
            // 
            this.txtAlePac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtAlePac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "alergias", true));
            this.txtAlePac.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtAlePac.Location = new System.Drawing.Point(147, 148);
            this.txtAlePac.Multiline = true;
            this.txtAlePac.Name = "txtAlePac";
            this.txtAlePac.Size = new System.Drawing.Size(189, 42);
            this.txtAlePac.TabIndex = 10;
            // 
            // txtAdesPac
            // 
            this.txtAdesPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.txtAdesPac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "adestacar", true));
            this.txtAdesPac.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtAdesPac.Location = new System.Drawing.Point(147, 196);
            this.txtAdesPac.Multiline = true;
            this.txtAdesPac.Name = "txtAdesPac";
            this.txtAdesPac.Size = new System.Drawing.Size(189, 39);
            this.txtAdesPac.TabIndex = 12;
            // 
            // frmPac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(384, 252);
            this.Controls.Add(lblIDPac);
            this.Controls.Add(this.lblNoIDPac);
            this.Controls.Add(lblNomPac);
            this.Controls.Add(this.txtApellPac);
            this.Controls.Add(lblApellPac);
            this.Controls.Add(this.txtNomPac);
            this.Controls.Add(lblLocPac);
            this.Controls.Add(this.txtLocPac);
            this.Controls.Add(lblAlerPac);
            this.Controls.Add(this.txtAlePac);
            this.Controls.Add(lblAdesPac);
            this.Controls.Add(this.txtAdesPac);
            this.Controls.Add(this.pacientesBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPac";
            this.Load += new System.EventHandler(this.frmPac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingNavigator)).EndInit();
            this.pacientesBindingNavigator.ResumeLayout(false);
            this.pacientesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private hospitalDs hospitalDs;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private hospitalDsTableAdapters.pacientesTableAdapter pacientesTableAdapter;
        private hospitalDsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pacientesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pacientesBindingNavigatorSaveItem;
        private System.Windows.Forms.Label lblNoIDPac;
        private System.Windows.Forms.TextBox txtApellPac;
        private System.Windows.Forms.TextBox txtNomPac;
        private System.Windows.Forms.TextBox txtLocPac;
        private System.Windows.Forms.TextBox txtAlePac;
        private System.Windows.Forms.TextBox txtAdesPac;
    }
}