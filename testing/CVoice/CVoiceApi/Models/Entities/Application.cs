using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CVoiceApi.Models.Entities
{
    public class Application
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ApplicationType { get; set; }
        public string ApplicationPurpose { get; set; }
        public string HostName { get; set; }
        public bool IsPublic { get; set; }
        public BsonDateTime CreatedDay { get; set; }
        public string CreatedByUser { get; set; }
    }
}
