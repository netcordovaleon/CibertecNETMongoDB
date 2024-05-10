using MongoDB.Bson.Serialization.Attributes;

namespace APIMongoDB.Services
{
    public class PetEntity
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; } = null;
        public string Name { get; set; }
        public string Specie { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public string Gender { get; set; }
    }
}
