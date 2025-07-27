using Microsoft.AspNetCore.Mvc;

namespace AppleApp.ViewComponents.Home
{
    public class _AboutPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
