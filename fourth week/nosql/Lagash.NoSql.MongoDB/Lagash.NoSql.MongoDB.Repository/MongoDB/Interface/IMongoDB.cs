using MongoDB.Driver;

namespace Lagash.NoSql.MongoDB.Repository.MongoDB
{
    public interface IMongoDB
    {
        void CreateOrUpdate<T>(T model, string collectionName);        
    }
}
