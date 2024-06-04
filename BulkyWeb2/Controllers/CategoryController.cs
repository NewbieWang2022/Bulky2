using BulkyWeb2.Data;
using Microsoft.AspNetCore.Mvc;
using BulkyWeb2.Models;

namespace BulkyWeb2.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicaionDbContext _db;
        public CategoryController(ApplicaionDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
