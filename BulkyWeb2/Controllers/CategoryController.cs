using Microsoft.AspNetCore.Mvc;
using BulkyWeb2.Data;
using BulkyWeb2.Models;

namespace BulkyWeb2.Controllers
{
    public class CategoryController : Controller 
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View();
        }
    }
}
