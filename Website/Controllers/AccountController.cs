using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Security.Claims;
using BuisnessLogicLevel.BuisnessLogicEntities;
using BuisnessLogicLevel.Interfaces;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Website.Models;

namespace Website.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService userService;

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        public AccountController(IUserService userService)
        {
            this.userService = userService;
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                UserTransferModel user = new UserTransferModel { Email = model.Email, Password = model.Password };
                ClaimsIdentity claim = await userService.Authenticate(user);
                if (claim == null)
                {
                    ModelState.AddModelError(string.Empty, "Неверный логин или пароль.");
                }
                else
                {
                    AuthenticationManager.SignOut();
                    AuthenticationManager.SignIn(
                        new AuthenticationProperties
                        {
                            IsPersistent = true
                        },
                        claim);
                    return RedirectToAction("Index", "Home");
                }
            }

            return View(model);
        }

        public ActionResult Logout()
        {
            AuthenticationManager.SignOut();
            return RedirectToAction("Login", "Account");
        }

    }
}
