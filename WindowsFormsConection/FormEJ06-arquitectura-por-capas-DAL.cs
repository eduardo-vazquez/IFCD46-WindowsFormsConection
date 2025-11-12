using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsConection
{

    public partial class FormEJ06_arquitectura_por_capas_DAL : Form
    {
        DbConnect coneccionBDEmployees;
        public FormEJ06_arquitectura_por_capas_DAL()
        {
            InitializeComponent();

            // Crear objeto de conexion y guardarlo en una variable de clase
            coneccionBDEmployees = new DbConnect();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                coneccionBDEmployees.Open();
                tbxEstadoDeConeccion.Text = "Conectado";
                //verificar estado de coneccion con el metodo GetConnectionState
                if (coneccionBDEmployees.GetConnectionState() == ConnectionState.Open)
                    tbxEstadoDeConeccion.BackColor = Color.LightGreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                coneccionBDEmployees.Close();
                tbxEstadoDeConeccion.Text = "Desconectado";
                //verificar estado de coneccion con el metodo GetConnectionState
                if (coneccionBDEmployees.GetConnectionState() == ConnectionState.Closed)
                    tbxEstadoDeConeccion.BackColor = Color.LightCoral;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al desconectar: " + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Job job = new Job(
                null,
                tbxJobTitle.Text,
                string.IsNullOrEmpty(tbxMinSalary.Text) ? (decimal?)null : decimal.Parse(tbxMinSalary.Text),
                string.IsNullOrEmpty(tbxMaxSalary.Text) ? (decimal?)null : decimal.Parse(tbxMaxSalary.Text)
            );

            DALJob.Insertar(job, coneccionBDEmployees);
        }
    }
}
