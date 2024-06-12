using EsyaKira.Dto.ProductDtos;

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EsyaKira.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultLast5ProductsWithBrandsComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DefaultLast5ProductsWithBrandsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7029/api/Products/GetLast5ProductsWithBrandQueryHandler");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast5ProductsWithBrandsDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
