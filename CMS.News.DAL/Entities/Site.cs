namespace CMS.News.DAL.Entities
{
    public class Site
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
