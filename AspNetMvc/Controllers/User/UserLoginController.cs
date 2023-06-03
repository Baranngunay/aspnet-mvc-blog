using Microsoft.AspNetCore.Mvc;

namespace MVC_PROJE.Controllers.User
{
    public class UserLoginController : BaseUserController
    {
        public IActionResult Login(string redirectUrl)
        {
            return View();
        }
    }
}
