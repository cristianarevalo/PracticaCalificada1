using Microsoft.AspNetCore.Mvc;
using PracticaCalificada1.UnitOfWork;

namespace PracticaCalificada1.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unit;

        public ProductController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        public IActionResult Index()
        {
            return View(_unit.Products.SearchByName("LL Crankarm"));
        }

        public IActionResult List()
        {
            return View(_unit.Products.GetAll());
        }
    }
}