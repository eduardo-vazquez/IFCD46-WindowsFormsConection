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
    public partial class FormEJ05 : Form
    {
        string connectionString;
        SqlConnection connection;

        public FormEJ05()
        {
            InitializeComponent();

            var csb = new SqlConnectionStringBuilder
            {
                DataSource = "187.33.155.14,54321",
                InitialCatalog = "EduardoEmployees",
                UserID = "sa",
                Password = Program.Password
            };
            connectionString = csb.ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                tbxEstadoDeConeccion.Text = "Conectado";
                if (connection.State == ConnectionState.Open)
                    tbxEstadoDeConeccion.BackColor = Color.LightGreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            connection.Close();
            tbxEstadoDeConeccion.Text = "Desconectado";
            tbxEstadoDeConeccion.BackColor = Color.LightCoral;
        }

        private void Insertar(Job job)
        {
            string sql = $@"INSERT INTO jobs(job_title, min_salary, max_salary) 
                VALUES('@jobTitle', @min_salary, @max_salary)";

            try
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@title", job.job_title ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@min", job.min_salary ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@max", job.max_salary ?? (object)DBNull.Value);

                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    command.ExecuteNonQuery();
                    MessageBox.Show("Registro insertado correctamente ✅");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Si prefieres que este método cierre la conexión:
                // if (connection.State == ConnectionState.Open) connection.Close();
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
            Insertar(job);
        }
    }
}
