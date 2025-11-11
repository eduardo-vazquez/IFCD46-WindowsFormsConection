using System;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsConection
{
    public class DbConnect
    {
        public string ConnectionString { get; }
        public SqlConnection Connection { get; }

        // Constructor con parametros con valores por defecto
        public DbConnect(
            string dataSource = "187.33.155.14,54321",
            string initialCatalog = "EduardoEmployees",
            string userId = "sa",
            string password = null) 
        {
            // Establecer la "cadena" de conexion usando SqlConnectionStringBuilder
            var dbConnectionBuilder = new SqlConnectionStringBuilder
            {
                DataSource = dataSource,
                InitialCatalog = initialCatalog,
                UserID = userId,
                Password = password ?? Program.Password,
                IntegratedSecurity = false
            };

            // Usar el metodo ConnectionString para obtener la cadena de conexion
            ConnectionString = dbConnectionBuilder.ConnectionString;

            // Aqui se crea la conexion en si
            Connection = new SqlConnection(ConnectionString);
        }

        public void Open()
        {
            if (Connection.State != ConnectionState.Open)
                Connection.Open();
        }

        public void Close()
        {
            if (Connection.State != ConnectionState.Closed)
                Connection.Close();
        }

    }
}
