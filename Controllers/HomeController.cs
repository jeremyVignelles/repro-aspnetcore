using Microsoft.AspNetCore.Mvc;

namespace Repro.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello !";
        }
    }
}
