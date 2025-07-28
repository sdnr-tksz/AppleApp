using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AppleApp.ViewComponents.Home
{
    public class _ProjectPartial:ViewComponent
    {

        ProjectManager projectManager= new ProjectManager(new EfProjectDal());
        public IViewComponentResult Invoke()
        {
            var values = projectManager.TGetList();
            return View(values);
        }

    }
}
