using FBKsystem.Models;
using FBKsystem.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FBKsystem.Controllers
{
   
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IBiodataRepository _memberRepository;

        public AccountController(IBiodataRepository memberRepository, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _memberRepository = memberRepository;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        //[AllowAnonymous]
        //public IActionResult Login( string returnUrl="/")
        //{
        //    return View(new LoginVM { returnUrl = returnUrl });
        //}

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(Biodata member)
        {
            var userExist = _userManager.FindByNameAsync(member.MemberId);
            if (userExist == null)
            {
                try
                {
                    var user = new ApplicationUser
                    {
                        UserName = member.MemberId,
                        Email = member.Firstname[0] + member.MemberId[2] + member.Lastname + "@stu.ui.edu.ng"
                    };
                    var createUser = await _userManager.AddPasswordAsync(user, member.Firstname.ToLower());
                    if (createUser.Succeeded)
                    {
                        _memberRepository.CreateMember(member);
                    }
                    return View("Success");
                }
                catch (Exception)
                {

                    throw;
                } 
            }
          return View();
        }

        //[HttpPost]
        //[AllowAnonymous]
        //public async Task<IActionResult> login(LoginVM model)
        //{
        //    var user = await _userManager.FindByNameAsync(model.MemberId);
        //    if (user == null)
        //        return Unauthorized();
        //    //var isSucceded = await _signInManager.PasswordSignInAsync(login.MemberId, login.Password, false, false);
        //    //if (isSucceded.Succeeded)
        //    //{
        //    //    return RedirectToAction("Dashboard", "Member");
        //    //}
        //    //ModelState.AddModelError("", "Invalid Username/Password");
        //    //return View();
        //    var claims = new List<Claim>
        //    {
        //        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
        //        new Claim(ClaimTypes.Email, user.Email),
        //        new Claim(ClaimTypes.Name, user.UserName),
        //    };
        //    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        //    var principal = new ClaimsPrincipal(identity);
        //    await HttpContext.SignInAsync(
        //        CookieAuthenticationDefaults.AuthenticationScheme,
        //        principal,
        //        new AuthenticationProperties { IsPersistent = model.RememberMe });
        //    return LocalRedirect(model.returnUrl);
        //}
        public async Task <IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/");
        }
        public IActionResult Success()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
