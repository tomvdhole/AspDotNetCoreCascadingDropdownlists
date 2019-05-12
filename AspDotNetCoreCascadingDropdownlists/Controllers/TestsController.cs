using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AspDotNetCoreCascadingDropdownlists.Models;

namespace AspDotNetCoreCascadingDropdownlists.Controllers
{
    public class TestsController : Controller
    {
        private readonly AspDotNetCoreCascadingDropdownlistsContext _context;

        public TestsController(AspDotNetCoreCascadingDropdownlistsContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _context.Categories.ToListAsync();         
            return View(new SelectProductViewModel(categories, null, null));
        }

        #region Methods that return JSON
        public async Task<IActionResult> GetSubCategories(int category)
        {
            var subCategories = await _context.SubCategories.Where(s => s.CategoryId == category).ToListAsync();
            var viewModel = new SelectProductViewModel(null, subCategories, null);
            return Json(viewModel.SubCategories);
        }

        public async Task<IActionResult> GetProducts(int subCategory)
        {
            var products = await _context.Products.Where(p => p.SubCategoryId == subCategory).ToListAsync();
            var viewModel = new SelectProductViewModel(null, null, products);
            return Json(viewModel.Products);
        }
        #endregion
    }
}
