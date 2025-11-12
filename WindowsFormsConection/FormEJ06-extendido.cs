using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsConection
{
    public partial class FormEJ06_extendido : Form
    {
        public FormEJ06_extendido()
        {
            InitializeComponent();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            Job
                job = new Job(
                null,
                tbxJobTitle.Text,
                string.IsNullOrEmpty(tbxMinSalary.Text) ? (decimal?)null : decimal.Parse(tbxMinSalary.Text),
                string.IsNullOrEmpty(tbxMaxSalary.Text) ? (decimal?)null : decimal.Parse(tbxMaxSalary.Text)
            );

            try
            {

                DALJobWithConnection.Insertar(job);
                ClearBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el registro: " + ex.Message);
            }
        }

        private void CargarJobsEnGrid(object sender, EventArgs e)
        {
            try
            {
                List<Job> listaJobs = DALJobWithConnection.ObtenerTablaDeJobs();
                dgvTablaJobs.DataSource = listaJobs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los registros: " + ex.Message);
            }
        }

        private void ClearBox()
        {
            tbxJobTitle.Clear();
            tbxMinSalary.Clear();
            tbxMaxSalary.Clear();
        }
    }
}
