using Microsoft.AspNetCore.Mvc;

namespace AppleApp.ViewComponents.Home
{
    public class _ProjectPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
