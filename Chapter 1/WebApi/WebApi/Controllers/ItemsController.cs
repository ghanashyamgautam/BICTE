using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            var items = new List<Item>
            {
                new Item { Id = 1, Name = "Item 1", Description = "This is the first sample item.", Price = 10.99 },
                new Item { Id = 2, Name = "Item 2", Description = "This is the second sample item.", Price = 15.49 },
                new Item { Id = 3, Name = "Item 3", Description = "This is the third sample item.", Price = 7.99 }
            };

            return Ok(items);
        }
    }
}
