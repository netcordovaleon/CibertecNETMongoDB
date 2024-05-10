using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Formats.Asn1;

namespace APIMongoDB.Services
{
    public class PetServices
    {
        private readonly IMongoCollection<PetEntity> _petCollection;

        public PetServices(IOptions<PetDatabaseConfig> petDataBaseConfig)
        {
            var mongoClient = new MongoClient(petDataBaseConfig.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(petDataBaseConfig.Value.DatabaseName);

            _petCollection = mongoDatabase.GetCollection<PetEntity>(petDataBaseConfig.Value.PetCollectionName);
        }

        public async Task SavePetAsync(PetEntity entity) {

            await _petCollection.InsertOneAsync(entity);
        }


        public async Task<List<PetEntity>> GetAllAsync() {
            return await _petCollection.Find(_ => true).ToListAsync();
        }

    }
}
