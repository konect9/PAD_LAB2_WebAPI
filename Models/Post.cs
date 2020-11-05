using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace SocialApi.Models
{
    public class Post
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("title")]
        [JsonProperty("title")]

        public string title { get; set; }

        public string date_created { get; set; }

        public string body { get; set; }

        public string category { get; set; }

        public string user_name { get; set; }

        public decimal userID { get; set; }

        public decimal views { get; set; }

        public decimal likes { get; set; }
    }
}
