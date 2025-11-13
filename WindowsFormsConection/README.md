Acceso a datos: BD employees - Open/Close

1a parte

- Montar app winforms con 2 botones, para abrir y cerrar la conexión

- Usar la calse SqlConnection, dentro de un try/catch

- Definir la cadena de conexión, con los 4 parametros de acceso


2a parte

- Añadir un metodo Insertar()

- usar SqlCommand, y su metodo ExecuteNonQuery

- pasarle el codigo SQL para hacer un INSERT INTO en la tabla jobs

- Insertar valores concretos (hard coded)

- usar  try/catch/finally


3a parte

- insertar un Job basado en valores del usuario (txtBox...) 

- separar DAL/UI

- Gestionar valores nulos: NULL vs null


4a parte

- Crear el Modelo, clase correspondiente a la tabla de la BD (jobs, en nuestro caso)

- Pasar un objeto Job a Insertar()


5a parte

- inyección SQL:

https://www.mclibre.org/consultar/php/lecciones/php-db-inyeccion-sql.html

https://es.wikipedia.org/wiki/Inyecci%C3%B3n_SQL

- Usar parametros

- Separación en capas

- Clases DAL y Modelos

Separar las capas en el proyecto que tenemos:

- Crear carpetas /Modelo y /DAL

- Mover la clase Job en /Model

- Crear la clase DbConnect, con la cnx (SqlConnection), Open, Close y la cadena de cnx

- Crear la clase DALJob, y mover alli los métodos Insertar XX()

- Añadir el uso de DBConnect en vez de SqlConnection: crear objeto DBConnect, llamar a Open antes, y CLose después de ejecutar la acción

Extensión del proyecto:

- Añadir control para mostar una lista de jobs + botón Cargar

- En DALJob añadir el metodo GetAll() que devuelve List<Job>

- Gestionar lo de Insertar vs la lista

- Permitir modificar un job existente, y guardarlo en la BD


6a parte

- añadir SELECT SCOPE_IDENTITY() al final del comando INSERT (separación con ; )

- ejecutar en comando con ExecuteScalar() en vez de ExecuteNonQuery, para recuperar el valor

- es el ID del registro recien insertado, para actualizar el obejto Job pasado, que no tenía aun valor para ID


