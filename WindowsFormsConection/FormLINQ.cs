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
    public partial class FormLINQ : Form
    {
        public FormLINQ()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
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
                DALJobLINQ.Insertar(job);
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
                dgvTablaJobs.DataSource = DALJobLINQ.ObtenerRegistroDeTabla<jobs>();
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

        private void btnActualizarDGV_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTablaJobs.DataSource = DALJobLINQ.ObtenerRegistroDeTabla<jobs>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los registros: " + ex.Message);
            }
        }
    }
}
