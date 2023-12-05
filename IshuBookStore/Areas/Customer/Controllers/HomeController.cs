using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IshuBookStore.DataAccess.Repository; // Correct the namespace
using IshuBooks.Models;
using IshuBookStore.Models;
using IshuBookStore.Models.ViewModels;
using System.Diagnostics;
using System.Collections.Generic;
using IshuBookStore.DataAccess.Respository;

namespace IshuBookStore.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UnitOFWork unitOfWork;

        public HomeController(ILogger<HomeController> logger, UnitOFWork unitOfWork)
        {
            _logger = logger;
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> productList = unitOfWork.Product.GetAll(includeProperties: "Category,CoverType");
            // Add logic to use productList as needed
            return View(productList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
