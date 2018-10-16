using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.IO;
using Microsoft.Extensions.Configuration.Json;
using System.Security.Authentication;

namespace Lagash.NoSql.MongoDB.Repository.MongoDB
{
    public class MongoDb : IMongoDB
    {
        private readonly string userName;
        private readonly string host;
        private readonly string password;
        private readonly string mechanism;
        private readonly string connectionString;
        private readonly string dbName;
        private readonly Configuration settings;
        private static IConfigurationRoot configuration;

        public MongoDb()
        {
            var builder = new ConfigurationBuilder()
                          .SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile("appSetting.json");

            configuration = builder.Build();


            connectionString = configuration["ConnectionString"];
            host = configuration["Host"];
            password = configuration["Password"];
            userName = configuration["Username"];
            dbName = configuration["DatabaseName"];
            mechanism = configuration["Mechanism"];          
        }
        // To do: update the connection string with the DNS name
        // or IP address of your server. 
        //For example, "mongodb://testlinux.cloudapp.net


        // This sample uses a database named "Tasks" and a 
        //collection named "TasksList".  The database and collection 
        //will be automatically created if they don't already exist.

        private MongoClientSettings Connect()
        {
            MongoClientSettings settings = MongoClientSettings.FromUrl(
              new MongoUrl(connectionString)
            );
            settings.SslSettings = new SslSettings() { EnabledSslProtocols = SslProtocols.Tls12 };

            return settings;
        }

        public void CreateOrUpdate<T>(T model, string collectionName)
        {
            var collection = GetCollection<T>(collectionName);
            collection.InsertOne(model);
        }

        private IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            var settings = this.Connect();

            MongoClient client = new MongoClient(settings);
            var database = client.GetDatabase(dbName);
            var cartCollection = database.GetCollection<T>(collectionName);

            return cartCollection;
        }
    }
}
