﻿using Microsoft.AspNetCore.Mvc;

namespace AppleApp.ViewComponents.Home
{
    public class _SliderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
