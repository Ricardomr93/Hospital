using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class frmPac : Form
    {
        public frmPac()
        {
            InitializeComponent();
        }

        private void pacientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (is_valide())
                {
                    this.Validate();
                    this.pacientesBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.hospitalDs);
                    bindingNavigatorAddNewItem.Enabled = true;//habilita el boton de nuevo registro
                    DialogResult r = MessageBox.Show("Guardado con éxito \nDesea continuar?", "Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.No)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No se ha podido guardar, campos obligatorios vacios", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (NoNullAllowedException ex)
            {
                MessageBox.Show("No se ha podido guardar, " + ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido guardar, campos obligatorios vacios", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exp)
            {
                MessageBox.Show("No se ha podido guardar, " + exp.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool is_valide()
        {
            bool valid = true;
            int e = errorTxt(txtNomPac) + errorTxt(txtApellPac) + errorTxt(txtLocPac);
            if (e > 0)
            {
                valid = false;
            }
            return valid;

        }

        private int errorTxt(TextBox t)
        {
            int e = 0;
            if (t.Text.Equals("") || t == null)
            {
                e++;
            }
            return e;
        }

        private void frmPac_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospitalDs.pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.hospitalDs.pacientes);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = false;//para evitar excepciones

        }
    }
}
