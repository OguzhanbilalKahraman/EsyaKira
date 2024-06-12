using EsyaKira.Dto.ServiceDtos;
using EsyaKira.Dto.TestimonialDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EsyaKira.WebUI.Controllers
{
    public class ServiceController : Controller
    {
 
        public IActionResult Index()
        {
            ViewBag.v1 = "Hizmetler";
            ViewBag.v2 = "Hizmetlerimiz";

            return View();
        }
    }
}
