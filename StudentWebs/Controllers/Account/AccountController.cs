using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using StudentWebs.Data;
using StudentWebs.Models.Accountadm;
using StudentWebs.Models.ViewModel;
using System.Security.Claims;

namespace StudentWebs.Controllers.Account
{
    public class AccountController : Controller
    {
        private readonly DataContext _context;
        public AccountController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login model)
        {


            if (ModelState.IsValid)
            {
                var user = _context.Users.SingleOrDefault(u => u.UserName == model.UserName);

                if (user != null)
                {
                    if (user.Password == model.Password)
                    {

                        var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, model.UserName) }, CookieAuthenticationDefaults.AuthenticationScheme);
                        var principal = new ClaimsPrincipal(identity);
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                        HttpContext.Session.SetString("UserName", model.UserName);

                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("Password", "Invalid password!");
                    }
                }
                else
                {
                    ModelState.AddModelError("UserName", "Invalid password");
                }
            }
            return View(model);
        }
           
   

        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            var storedCookies = Request.Cookies.Keys;
            foreach (var cookies in storedCookies)
            {
                Response.Cookies.Delete(cookies);
            }
            return RedirectToAction("Login", "Account");
        }
        public IActionResult SignUp() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(LoginSignUpViewModel model,User user)
        {
            bool isUsernameExists = _context.Users.Any(s => s.UserName == user.UserName);
            if (isUsernameExists)
            {
                ModelState.AddModelError("UserName", "Username already exists. Create unique Username.");
            }
            if (ModelState.IsValid)
            {
                var data = new User()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    Password = model.Password,
                    Mobile = model.Mobile,
                };
                _context.Users.Add(data);
                await _context.SaveChangesAsync();
                TempData["successMessage"] = "You are eligible to login,Please fill your own credentials then login!";
                return RedirectToAction("Login");
            }
            else
            {
                return View(model);
            }
        }
    }
}
