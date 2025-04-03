namespace Webshop.Core.Models.Domains
{
    public class Todo
    {
        public Guid TodoId { get; set; }
        public string Task { get; set; }
        public string Description { get; set; }
        public DateTime ExpiresOn { get; set; }
    }
}
