Evaluación Técnica Coink

Anotaciones:
1. La base de datos utilizada fue Postgres, la creación de la base de datos se hace mediante migraciones que ejecutan los scripts de creación del esquema.
2. Los endpoints permiten consultar Paises, Departamentos, Municipios y Usuarios. También permiten crear usuarios.
3. Los scripts requeridos para la creación de la base de datos y un ejemplo de stored procedure se encuentran en la carpeta "scripts".
4. Resumen de patrones de diseño:
   
   -Repositorio: La clase "DbContext.cs" es la encargada de gestionar la conexión a la base de datos.
   
   -Contolador: Se utilizan controladores de cada entidad, que se encuentran en la carpeta "Controllers" los cuales tienen como objetivo manejar las rutas de los endpoints de los servicios expuestos.
   
   -Entidades y Lógica: La carpeta "Entities" contiene las entidades utilizadas y en cada una de ellas se maneja su lógica.
   
