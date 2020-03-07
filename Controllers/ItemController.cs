using linx_backend.Models;
using Microsoft.AspNetCore.Mvc;


namespace linx_backend.Controllers
{
    [ApiController]
    [Route("api")]
    public class ItemController : ControllerBase
    {
        private readonly ItemContext _context;

        [HttpGet("item")]
        public Item getItem()
        {
            var item = new Item(1, "Alessandro", 10);

            _context.Items.Add(item);
            _context.SaveChanges();

            return item;
        }

        [HttpGet("item/{id}")]
        public ActionResult<Item> getById(long id) {
            var item = _context.Items.Find(id);
            if(item == null)
            {
                return NotFound();
            }
            return item;
        }
    }
}
