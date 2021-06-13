# PrograAvanzada7mo

## Carpeta Business (capa)
En esta solución es donde se hacen las interacciones con la base de datos desde el proyecto principal. Es decir, es donde recide el CRUD en escencia.

## Carpeta Entities (entidades)
En esta solución es donde se declaran todos los modelos con los que se va a trabajar, se hace uso de los DataAnnotations para definir propiedades que tendrán las tablas que se creen a partir de las entidades declaradas.

## Carpeta DatAccess (capa de acceso de datos)
En esta solución es donde se establece la conexión con Sql Server y se realizan las migraciones. Para realizar las migraciones se tienen que seguir los siguientes pasos:

- Abrir NuGet Packet Manager Console
- Seleccionar el proyecto DataAccess
- Correr el comando: update-database
- Esperar a que termine

## Carpeta CetiPermisos
Solucion web.
