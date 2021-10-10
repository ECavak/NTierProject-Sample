using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NTierProject.DATAACCESS.Repositories.Concrate;
using NTierProject.DATAACCESS.Repositories.Context;
using NTierProject.WEBUI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NTierProject.WEBUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        UserRepository _userRepository;
        CategoryRepository _categoryRepository;
        ProductRepository _productRepository;
        public HomeController(ILogger<HomeController> logger,ProjectContext context)
        {
            _userRepository = new UserRepository(context);
            _categoryRepository = new CategoryRepository(context);
            _productRepository = new ProductRepository(context);

            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_categoryRepository.GetActive());
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
