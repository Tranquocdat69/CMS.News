namespace CMS.News.DAL.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Fullname { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public bool IsAllowLoginMultiSession { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public Guid SiteId { get; set; }

        public Site Site { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
