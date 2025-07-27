using Microsoft.AspNetCore.Mvc;

namespace AppleApp.ViewComponents.Home
{
    public class _TestimonialPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
