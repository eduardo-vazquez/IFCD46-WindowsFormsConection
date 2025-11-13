using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsConection
{
    internal class DALJobLINQ
    {
        static public void Insertar(Job job)
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

        static public List<T> ObtenerRegistroDeTabla<T>() where T : class
        {
            var db = new DataEduardoEmployeesDataContext();

            try
            {
                return db.GetTable<T>().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener datos de {typeof(T).Name}: {ex.Message}");
                return new List<T>();
            }
            finally
            {
                // Me aseguro de liberar los recursos
                db.Dispose();
            }

            // Explicación del código:
            // public List<T> ObtenerRegistroDeTabla<T>(): método público que devuelve List<T> y no recibe parámetros.T es el tipo genérico.
            // where T : class: restricción para T: que T sea una clase presente en el modelo LINQ to SQL (por ejemplo, Job, Employee, Department, etc.).
            // return db.GetTable<T>().ToList();: obtiene la tabla correspondiente al tipo T y convierte los resultados en una lista de objetos T. 
            // en donde la T es el tipo de clase que se haya especificado al llamar al método.

            // PARA USARLO:
            // List<Job> listaJobs = DALJobLINQ.ObtenerRegistroDeTabla<Job>();
        }



    }
}
