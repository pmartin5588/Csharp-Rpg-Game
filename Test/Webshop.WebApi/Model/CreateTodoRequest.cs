namespace Webshop.Api.Model
{
    public class CreateTodoRequest
    {
        public string Task { get; set; }
        public string Description { get; set; }
        public DateTime ExpiresOn { get; set; }
    }
}
