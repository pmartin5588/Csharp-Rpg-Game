using Microsoft.AspNetCore.Mvc;

namespace Webshop.WebApi.Model
{
    public class Order
    {
        [FromQuery]
        public string? Name { get; set; }

        [FromQuery]
        public int? Age { get; set; }
    }
}
