using Hospital.hospitalDsTableAdapters;
using Hospital.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class frmPrincipal : Form
    {
        ArrayList idMed = new ArrayList();
        ArrayList idPac = new ArrayList();
        ArrayList idMedC = new ArrayList();
        private byte[] MyData;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospitalDs.especialidades' Puede moverla o quitarla según sea necesario.
            this.especialidadesTableAdapter.Fill(this.hospitalDs.especialidades);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDs.medicos' Puede moverla o quitarla según sea necesario.
            //this.medicosTableAdapter.Fill(this.hospitalDs.medicos);
            rljFecha.Start();
            rljHora.Start();
            cargarcmbbMedicos();
            // dgvCitas.DataSource = hospitalDs.atenmedpac;
            cargarcmbbNomMedEspe();
            cargarcmbbEspe();


        }

        private void rljFecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void rljHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }
        private void cargarcmbbMedicos()
        {
            cmbbNomAten.Items.Clear();
            idMedC.Clear();
            try
            {
                medicosTableAdapter.Fill(hospitalDs.medicos);
                for (int i = 0; i < hospitalDs.medicos.Count; i++)
                {
                    cmbbMedCita.Items.Add(hospitalDs.medicos[i].nombre);
                    idMedC.Add(hospitalDs.medicos[i].idmedico);
                }
            }
            catch (ConstraintException)
            {
                cmbbNomAten.Text = "";
            }
        }
        private void cargarcmbbPacientes()
        {
            cmbbPacAten.Items.Clear();
            idPac.Clear();
            pacientesTableAdapter.Fill(hospitalDs.pacientes);
            for (int i = 0; i < hospitalDs.pacientes.Count; i++)
            {
                cmbbPacAten.Items.Add(hospitalDs.pacientes[i].nombre);
                idPac.Add(hospitalDs.pacientes[i].idpaciente);
            }
        }

        private void cargarcmbbNomMedEspe()
        {
            cmbbNomAten.Items.Clear();
            idMed.Clear();
            medicosTableAdapter.FillByEspecialidad(hospitalDs.medicos, cmbbEspeAten.Text);
            for (int i = 0; i < hospitalDs.medicos.Count; i++)
            {
                cmbbNomAten.Items.Add(hospitalDs.medicos[i].nombre);
                idMed.Add(hospitalDs.medicos[i].idmedico);
            }
        }
        private void cargarcmbbEspe()
        {
            cmbbEspeAten.Items.Clear();
            especialidadesTableAdapter.Fill(hospitalDs.especialidades);
            for (int i = 0; i < hospitalDs.especialidades.Count; i++)
            {
                cmbbEspeAten.Items.Add(hospitalDs.especialidades[i].especialidad);
            }
        }


        private void cargarMedicos()
        {
            hospitalDs.medicos.Clear();
            medicosTableAdapter.FillByIDMed(hospitalDs.medicos, int.Parse(idMed[cmbbNomAten.SelectedIndex].ToString()));
            if (hospitalDs.medicos.Count > 0)
            {
                lblNoIDMed.Text = hospitalDs.medicos[0].idmedico.ToString();
                txtNomMed.Text = hospitalDs.medicos[0].nombre;
                txtApellMed.Text = hospitalDs.medicos[0].apellidos;
                txtMovMed.Text = hospitalDs.medicos[0].movil.ToString();
                txtEspeMed.Text = hospitalDs.medicos[0].especialidad;
            }

        }
        private void cargarPacientes()
        {
            hospitalDs.pacientes.Clear();
            pacientesTableAdapter.FillByIDPac(hospitalDs.pacientes, int.Parse(idPac[cmbbPacAten.SelectedIndex].ToString()));
            if (hospitalDs.medicos.Count > 0)
            {
                lblNoIDPac.Text = hospitalDs.pacientes[0].idpaciente.ToString();
                txtNomPac.Text = hospitalDs.pacientes[0].nombre;
                txtApellPac.Text = hospitalDs.pacientes[0].apellidos;
                txtAlerPac.Text = hospitalDs.pacientes[0].alergias;
                txtLocPac.Text = hospitalDs.pacientes[0].localidad;
                txtADesPac.Text = hospitalDs.pacientes[0].adestacar;
            }
        }
        private void cmbbEspeAten_SelectedValueChanged(object sender, EventArgs e)
        {
            cargarcmbbNomMedEspe();
        }

        private void cmbbNomAten_SelectedValueChanged(object sender, EventArgs e)
        {
            //cargamos los campos de la izquierda de medico
            cargarMedicos();
            //cambiamos el elemento del combobox de citas con el del de atencion
            if (cmbbNomAten.SelectedIndex >= 0)
            {
                cmbbMedCita.SelectedItem = cmbbNomAten.SelectedItem;
            }
            //cargamos el combo de pacientes
            cargarcmbbPacientes();
        }
        private void cmbbPacAten_SelectedValueChanged(object sender, EventArgs e)
        {
            cargarPacientes();
        }
        private void cmbbMedCita_SelectedValueChanged(object sender, EventArgs e)
        {
            int idm = int.Parse(idMedC[cmbbMedCita.SelectedIndex].ToString());
            medicosTableAdapter.FillByIDMed(hospitalDs.medicos, idm);
            lblNomEspeCita.Text = hospitalDs.medicos[0].especialidad;
            lblNoIDMedCita.Text = hospitalDs.medicos[0].idmedico.ToString();
            this.atenmedpacTableAdapter.FillByIDMed(this.hospitalDs.atenmedpac,idm);
        }
        private void btnGesMed_Click(object sender, EventArgs e)
        {
            frmMed fm = new frmMed();
            try
            {
                fm.ShowDialog();
            }
            catch (NoNullAllowedException)
            {
            }

        }

        private void lblNoIDMed_TextChanged(object sender, EventArgs e)
        {
            if (hospitalDs.medicos.Rows.Count > 0)
            {
                //Inicializamos una fila de datos en la cual se almacenaran todos los datos de la fila seleccionada
                //En este ejemplo nos quedamos con la primera
                DataRow myRow = hospitalDs.medicos.Rows[0];
                //Se almacena el campo foto de la tabla en el array de bytes
                try
                {
                    MyData = (byte[])myRow["foto"];
                    //Se inicializa un flujo en memoria del array de bytes
                    MemoryStream stream = new MemoryStream(MyData);
                    //En el picture box se muestra la imagen que esta almacenada en el flujo en memoria 
                    //el cual contiene el array de bytes
                    pcbMed.Image = Image.FromStream(stream);
                }
                catch (Exception)
                {
                    pcbMed.Image = Resources.medicos;
                }
            }
        }

        private void btnGesPac_Click(object sender, EventArgs e)
        {
            frmPac fp = new frmPac();
            try
            {
                fp.ShowDialog();
            }
            catch (NoNullAllowedException)
            {
            }
        }

        private void btnAnCita_Click(object sender, EventArgs e)
        {
            DateTime d = dtpFechaAten.Value;
            try
            {
                int pac = int.Parse(idPac[cmbbPacAten.SelectedIndex].ToString());
                int med = int.Parse(idMed[cmbbNomAten.SelectedIndex].ToString());

                // this.atencsmedicasTableAdapter.Insert(d, med, pac, "");
                atenmedpacTableAdapter.FillByIDMed(hospitalDs.atenmedpac, med);
                MessageBox.Show("Cita ha sido añádida", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetAtenMed();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Rellene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void resetAtenMed()
        {
            cmbbNomAten.Items.Clear();
            cmbbPacAten.Items.Clear();
            cargarcmbbEspe();
        }
    }
}
