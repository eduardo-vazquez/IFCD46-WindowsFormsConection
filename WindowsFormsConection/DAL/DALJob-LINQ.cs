using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsConection
{
    internal class DALJobLINQ
    {
        static public void InsertarLINQ(Job job)
        {
            DataEduardoEmployeesDataContext db = new DataEduardoEmployeesDataContext();

            try
            {
                // Crear una instancia de jobs(LINQ) y asignar los valores desde el objeto Job(PROYECTO) recibido
                jobs nuevoJob = new jobs
                {
                    job_title = job.job_title,
                    min_salary = job.min_salary,
                    max_salary = job.max_salary
                };

                db.jobs.InsertOnSubmit(nuevoJob);
                db.SubmitChanges();
            }
            catch { }

        }
            
    }
}
