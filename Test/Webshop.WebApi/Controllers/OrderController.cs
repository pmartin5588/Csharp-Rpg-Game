using Microsoft.AspNetCore.Mvc;
using Webshop.Core.Services;
using Webshop.WebApi.Model;

namespace Webshop.WebApi.Controllers
{
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        [Route("/order")]
        public string Get(Order order)
        {
            var result = _orderService.Reconcile();

            if (result == true)
            {
                return "Ok";
            }

            return "Not Ok";
        }
    }
}
