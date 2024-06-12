using Microsoft.AspNetCore.Mvc;

namespace EsyaKira.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultStatisticsComponentPartial:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
           return View();
        }
    }
}
