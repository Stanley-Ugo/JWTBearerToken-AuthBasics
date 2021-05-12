using Microsoft.AspNetCore.Http.Extensions;
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
            var query = new QueryBuilder();

            query.Add("redirectUri", redirect_uri);

            query.Add("state", state);

            return View(model: query.ToString());
        }


        [HttpPost]
        public IActionResult Authorize(string username, string redirectUri, string state)
        {
            const string code = "BABABABAB";

            return Redirect($"{redirectUri}");
        }

        public IActionResult Token()
        {
            return View();
        }
    }
}
