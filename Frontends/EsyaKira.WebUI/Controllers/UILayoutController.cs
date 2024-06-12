using Microsoft.AspNetCore.Mvc;

namespace EsyaKira.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
