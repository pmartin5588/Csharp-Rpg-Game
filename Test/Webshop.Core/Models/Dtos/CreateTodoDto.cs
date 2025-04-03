namespace Webshop.Core.Models.Dtos
{
    public class CreateTodoDto
    {
        public string Task { get; set; }
        public string Description { get; set; }
        public DateTime ExpiresOn { get; set; }
    }
}
