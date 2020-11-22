using System;
using Microsoft.AspNetCore.Mvc;

namespace Repro.Controllers
{
    [ApiExplorerSettings(IgnoreApi = false, GroupName = nameof(HomeController))]
    [Route("Home")]
    public class HomeController : Controller
    {
        [HttpGet]
        public string? Index()
        {
            if (new Random().Next(100) > 50)
            {
                return "Hello !";
            }

            return null;
        }
    }
}
