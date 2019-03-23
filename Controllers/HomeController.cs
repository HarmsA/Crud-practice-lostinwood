using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LostintheWoods.Models;

namespace LostintheWoods.Controllers
{
    public class HomeController : Controller
    {
        private WoodsContext dbContext;
        public HomeController(WoodsContext context)
        {
            dbContext = context;
        }
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [Route("NewTrail")]
        [HttpGet]
        public IActionResult NewTrail()
        {
            return View();
        }
        [HttpPost("create")]
        public IActionResult Create()
        {
            return View("Index");
        }

    }
}
