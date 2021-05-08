using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers
{
    public class OAuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Authorize(string response_type, string client_id, string redirect_uri, string scope, string state)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Authorize(string username, string response_type, string client_id, string redirect_uri, string scope, string state)
        {
            return View();
        }

        public IActionResult Token()
        {
            return View();
        }
    }
}
