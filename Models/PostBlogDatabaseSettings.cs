namespace SocialApi.Models
{
    public class PostBlogDatabaseSettings : IPostBlogDatabaseSettings
    {
        public string SocialCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IPostBlogDatabaseSettings
    {
        string SocialCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
