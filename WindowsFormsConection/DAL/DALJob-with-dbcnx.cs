using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsConection
{
    internal class DALJobWithConnection
    {
        // Inicializar la conexión estática para evitar NullReferenceException
        private static readonly DbConnect connection = new DbConnect();

        static public void Insertar(Job job)
        {
            string sql = @"INSERT INTO jobs(job_title, min_salary, max_salary) 
                VALUES(@jobTitle, @min_salary, @max_salary)";

            try
            {
                if (connection.GetConnectionState() != ConnectionState.Open)
                    connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection.Connection))
                {
                    command.Parameters.AddWithValue("@jobTitle", job.job_title ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@min_salary", job.min_salary ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@max_salary", job.max_salary ?? (object)DBNull.Value);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Registro insertado correctamente ✅");
                }
            }
            catch (SqlException)
            {
                // Re-lanzar para manejo en un nivel superior
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.GetConnectionState() != ConnectionState.Closed)
                    connection.Close();
            }
        }

        static public List<Job> ObtenerTablaDeJobs()
        {
            string sql = "SELECT * FROM jobs";
            List<Job> listaJobs = new List<Job>();

            try
            {
                if (connection.GetConnectionState() != ConnectionState.Open)
                    connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection.Connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Job job = new Job();
                            job.job_id = reader["job_id"] != DBNull.Value ? (int?)reader["job_id"] : null;
                            job.job_title = reader["job_title"] != DBNull.Value ? (string)reader["job_title"] : null;
                            job.min_salary = reader["min_salary"] != DBNull.Value ? (decimal?)reader["min_salary"] : null;
                            job.max_salary = reader["max_salary"] != DBNull.Value ? (decimal?)reader["max_salary"] : null;
                            listaJobs.Add(job);
                        }
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.GetConnectionState() != ConnectionState.Closed)
                    connection.Close();
            }
            return listaJobs;
        }
    }
}
