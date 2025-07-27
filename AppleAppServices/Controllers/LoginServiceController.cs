using AppleAppServices.Model;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppleAppServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginServiceController : ControllerBase
    {
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginModel loginModel)
        {
            using (var context = new Context())
            {
                var user = context.Guides.SingleOrDefault(u => u.UserName == loginModel.UserName && u.Password == loginModel.Password);

                if (user != null)
                {
                    return Ok("Login successful.");
                }
                else
                {
                    return Unauthorized("Invalid username or password.");
                }
            }
        }
    }
}
