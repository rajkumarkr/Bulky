using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BulkyWeb.Controllers
{
    [Route("[controller]")]
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ApplicationDbContext _db;
        public CategoryController(ILogger<CategoryController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            Console.WriteLine("objCategoryList");
            Console.WriteLine(objCategoryList);
            return View();
        }


    }
}