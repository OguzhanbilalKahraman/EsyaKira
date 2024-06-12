using Microsoft.AspNetCore.Mvc;

namespace EsyaKira.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
