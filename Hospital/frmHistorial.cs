using System;
using System.Collections;
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
    public partial class frmHistorial : Form
    {
        ArrayList idPac = new ArrayList();
        public frmHistorial()
        {
            InitializeComponent();
        }

        private void frm_historial_Load(object sender, EventArgs e)
        {
            cargarcmbbPacientes();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbbPacAten.SelectedIndex >= 0)
            {
                atenmedpacTableAdapter.FillByIDPac(this.hospitalDs.atenmedpac, int.Parse(idPac[cmbbPacAten.SelectedIndex].ToString()));
            }
            
        }
    }
}
