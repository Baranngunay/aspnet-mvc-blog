using Microsoft.AspNetCore.Mvc;

namespace MVC_PROJE.Controllers.User
{
    public class UserFPasswordController : BaseUserController
    {
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
