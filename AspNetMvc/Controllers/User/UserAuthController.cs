using Microsoft.AspNetCore.Mvc;

namespace MVC_PROJE.Controllers.User
{
    public class UserAuthController : BaseUserController
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
