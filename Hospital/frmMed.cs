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
    public partial class frmMed : Form
    {
        public frmMed()
        {
            InitializeComponent();
        }

        private void medicosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.medicosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hospitalDs);
                //MessageBox.Show("Guardado con éxito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bindingNavigatorAddNewItem.Enabled = true;//habilita el boton de nuevo registro
                DialogResult r =  MessageBox.Show("Guardado con éxito \nDesea continuar?", "Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.No)
                {
                    this.Close();
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

        private void frmMed_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospitalDs.especialidades' Puede moverla o quitarla según sea necesario.
            this.especialidadesTableAdapter.Fill(this.hospitalDs.especialidades);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDs.medicos' Puede moverla o quitarla según sea necesario.
            this.medicosTableAdapter.Fill(this.hospitalDs.medicos);

        }

        private void lblMedico_Click(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            DialogResult dres = ofdFoto.ShowDialog();

            if (dres == DialogResult.Abort)
            {
                return;
            }
            if (dres == DialogResult.Cancel)
            {
                return;
            }
            pcbMed.Image = Image.FromFile(ofdFoto.FileName);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = false;//inhabilita el boton para evitar excepciones
            lblNoIDMed.Visible = false;//oculta el label para evitar mostrar numeros negativos
        }
    }
}
