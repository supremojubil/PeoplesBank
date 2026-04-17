using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PeoplesBank.Controllers {
    public class AccountController : Controller {
        public IActionResult Index() {
            return View();
        }
        // ✅ ADD THIS (GET)
        [HttpGet]
        public IActionResult Login() {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password) {
            // TEMP LOGIN
            if (username == "admin" && password == "1234") {
                HttpContext.Session.SetString("User", username);
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Invalid Username or Password";
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout() {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");
        }
        //user model
        public class LoginModel {
            [Required(ErrorMessage = "Username is required.")]
            public string Username { get; set; }
            public string Password { get; set; }
        }
        public class RegisterModel {
            [Required(ErrorMessage = "Username is Required.")]
            [EmailAddress(ErrorMessage = "Invalid username.")]
            public string Username { get; set; }
            public string Password { get; set; }
        }
        public class PasswordResetModel {
            public string UserId { get; set; }
            public string Token { get; set; }
            [Required(ErrorMessage = "Password is required.")]
            [StringLength(50, ErrorMessage = "Password must be between 6 and 100 characters long.", MinimumLength = 6)]
            public string Password { get; set; }
            [Required(ErrorMessage = "Confirm Password is Required.")]
            [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Password doesn't match.")]
            public string ConfirmPassword { get; set; }
        }

        public class ForgotPasswordModel {
            [Required(ErrorMessage = "Username is Required.")]
            [EmailAddress(ErrorMessage = "Invalid email address.")]
            public string Email { get; set; }
        }
    }
}
