using EsyaKira.Dto.ProductPricingDtos;
using EsyaKira.Dto.ProductDtos;

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EsyaKira.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "Eşyalarımız";
            ViewBag.v2 = "Kiralamak istediğiniz Eşyayı Seçiniz";
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7029/api/ProductPricings");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductPricingWithProductDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
