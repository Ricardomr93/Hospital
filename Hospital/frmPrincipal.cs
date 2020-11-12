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
        ArrayList id = new ArrayList();
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
            cargarcmmbNomMedEspe();


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
            try
            {
                medicosTableAdapter.Fill(hospitalDs.medicos);
                for (int i = 0; i < hospitalDs.medicos.Count; i++)
                {
                    cmbbMedCita.Items.Add(hospitalDs.medicos[i].nombre);
                }
            }
            catch (ConstraintException ce)
            {
                cmbbNomAten.Text = "";
            }
        }
        private void cargarcmbbPacientes()
        {
            cmbbPacAten.Items.Clear();
            pacientesTableAdapter.Fill(hospitalDs.pacientes);
            for (int i = 0; i < hospitalDs.pacientes.Count; i++)
            {
                cmbbPacAten.Items.Add(hospitalDs.pacientes[i].nombre);
            }
        }

        private void cargarcmmbNomMedEspe()
        {
            cmbbNomAten.Items.Clear();
            id.Clear();
            medicosTableAdapter.FillByEspecialidad(hospitalDs.medicos, cmbbEspeAten.Text);
            for (int i = 0; i < hospitalDs.medicos.Count; i++)
            {
                cmbbNomAten.Items.Add(hospitalDs.medicos[i].nombre);
                id.Add(hospitalDs.medicos[i].idmedico);
            }
        }


        private void cargarMedicos()
        {
            hospitalDs.medicos.Clear();
            medicosTableAdapter.FillByIDMed(hospitalDs.medicos, int.Parse(id[cmbbNomAten.SelectedIndex].ToString()));
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
            pacientesTableAdapter.FillByNomPac(hospitalDs.pacientes, cmbbPacAten.Text);
            if (hospitalDs.medicos.Count > 0)
            {
                txtIDPac.Text = hospitalDs.pacientes[0].idpaciente.ToString();
                txtNomPac.Text = hospitalDs.pacientes[0].nombre;
                txtApellPac.Text = hospitalDs.pacientes[0].apellidos;
                txtAlerPac.Text = hospitalDs.pacientes[0].alergias;
                txtLocPac.Text = hospitalDs.pacientes[0].localidad;
                txtADesPac.Text = hospitalDs.pacientes[0].adestacar;
            }
        }
        private void cmbbEspeAten_SelectedValueChanged(object sender, EventArgs e)
        {
            cargarcmmbNomMedEspe();
        }

        private void cmbbNomAten_SelectedValueChanged(object sender, EventArgs e)
        {
            cargarMedicos();
            if (cmbbNomAten.SelectedIndex >= 0)
            {
                cmbbMedCita.SelectedItem = cmbbNomAten.SelectedItem;
            }

            cargarcmbbPacientes();
        }
        private void cmbbPacAten_SelectedValueChanged(object sender, EventArgs e)
        {
            cargarPacientes();
        }
        private void cmbbMedCita_SelectedValueChanged(object sender, EventArgs e)
        {
            this.atenmedpacTableAdapter.FillByNomMed(this.hospitalDs.atenmedpac, cmbbMedCita.Text);
            this.medicosTableAdapter.FillByNombreMed(this.hospitalDs.medicos, cmbbMedCita.Text);
            lblNomEspeCita.Text = hospitalDs.medicos[0].especialidad;
            lblNoIDMedCita.Text = hospitalDs.medicos[0].idmedico.ToString();

            // lblNomEspeCita.Text = hospitalDs.atencsmedicas[0].especialidad;
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
                //MessageBox.Show("No se ha podido guardar, " + ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
