using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}