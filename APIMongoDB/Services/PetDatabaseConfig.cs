namespace APIMongoDB.Services
{
    public class PetDatabaseConfig
    {
        public string ConnectionString { get; set; } = null;
        public string DatabaseName { get; set; } = "";
        public string PetCollectionName { get; set; } = string.Empty;
    }
}
