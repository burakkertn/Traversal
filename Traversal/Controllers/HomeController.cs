﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Traversal.Models;

namespace Traversal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index Sayfası Çağrıldı");
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("Privacy Sayfası Çağrıldı");
            return View();
        }
        public IActionResult Test()
        {
            _logger.LogInformation("Test Sayfası Çağrıldı");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}