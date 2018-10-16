# Ejemplo Net Core - MongoDb
En dicho repositorio, se podra observar un ejemplo de una aplicacion Net Core 2.0 que se conecta a un BD mongo, montada en Azure.

## Configuracion
Dentro del proyecto: Lagash.NoSql.MongoDB se encuentra el archivo AppSettings.json, el cual veran la siguiente configuracion.

{
  "Host": "lagashuniversity.documents.azure.com",
  "Username": "lagashuniversity",
  "Password": "mae5IG6kxl7qGhtzdF1RsYlw9h5aoQkXz6RatNjURDp9foK2HYmo9IX0Nthd0TfHZZtPGjr81M5JHqorxYqA4g==",
  "ConnectionString": "mongodb://lagashuniversity:THSbmeZbKeBV5FHjZ4mEvik2VZ8hJk6AvA40P5YI9SmHzPDe9MXzsE6QEmgH2xrcou6dqGrV4A4JeVmHj93Qfg==@lagashuniversity.documents.azure.com:10255/?ssl=true&replicaSet=globaldb",
  "DatabaseName": "Test",
  "Mechanism": ""
}

cada una de las keys corresponde a configuraciones de la DB de mongo, montada en Azure. 