using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsConection
{
    internal class DALJobWithConnection
    {
        // Mantenga solo una declaración de connectionABD
        private static readonly DbConnect connectionABD = new DbConnect();

        static public void Insertar(Job job)
        {
            string sql = @"INSERT INTO jobs(job_title, min_salary, max_salary) 
                VALUES(@jobTitle, @min_salary, @max_salary)";

            try
            {
                if (connectionABD.GetConnectionState() != ConnectionState.Open)
                    connectionABD.Open();

                using (SqlCommand command = new SqlCommand(sql, connectionABD.Connection))
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
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connectionABD.GetConnectionState() != ConnectionState.Closed)
                    connectionABD.Close();
            }
        }

        static public List<Job> ObtenerTablaDeJobs()
        {
            string sql = "SELECT * FROM jobs";
            List<Job> listaJobs = new List<Job>();

            try
            {
                if (connectionABD.GetConnectionState() != ConnectionState.Open)
                    connectionABD.Open();

                using (SqlCommand command = new SqlCommand(sql, connectionABD.Connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Job job = new Job
                            {
                                job_id = reader["job_id"] != DBNull.Value ? (int?)reader["job_id"] : null,
                                job_title = reader["job_title"] != DBNull.Value ? (string)reader["job_title"] : null,
                                min_salary = reader["min_salary"] != DBNull.Value ? (decimal?)reader["min_salary"] : null,
                                max_salary = reader["max_salary"] != DBNull.Value ? (decimal?)reader["max_salary"] : null
                            };
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
                if (connectionABD.GetConnectionState() != ConnectionState.Closed)
                    connectionABD.Close();
            }
            return listaJobs;
        }
    }
}
