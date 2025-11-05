using Microsoft.AspNetCore.Mvc;

namespace SyncSyntax.Controllers
{
    public class AuthController : Controller
    {
        //Register
        //Login
        //Logout
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
    }
}
