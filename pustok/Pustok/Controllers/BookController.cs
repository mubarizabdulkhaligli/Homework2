using Microsoft.AspNetCore.Mvc;
using Pustok.DAL;
using Pustok.Models;

namespace Pustok.Controllers
{
    public class BookController : Controller
    {
        readonly PustokDbContext _context;
        public BookController(PustokDbContext context)
        {
            _context = context;
        }
        public IActionResult GetDetail(int id)
        {
            Book book = _context.Books.First(x => x.Id == id);  
            return Json(book);
        }
    }
}
