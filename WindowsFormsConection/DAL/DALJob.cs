using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsConection
{
    internal class DALJob
    {
         static public void Insertar(Job job, DbConnect connection)
        {
            string sql = $@"INSERT INTO jobs(job_title, min_salary, max_salary) 
                VALUES(@jobTitle, @min_salary, @max_salary)";

            try
            {
                using (SqlCommand command = new SqlCommand(sql, connection.Connection))
                {
                    command.Parameters.AddWithValue("@jobTitle", job.job_title ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@min_salary", job.min_salary ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@max_salary", job.max_salary ?? (object)DBNull.Value);

                    if (connection.GetConnectionState() != ConnectionState.Open)
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


        }

    }
}
