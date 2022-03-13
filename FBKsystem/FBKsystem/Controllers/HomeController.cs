using FBKsystem.Models;
using FBKsystem.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FBKsystem.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly IBiodataRepository _memberRepository;

        public HomeController(IBiodataRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
         public IActionResult login(Biodata member)
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult fullprofile()
        {
            return View();
        }

       public IActionResult members()
        {
            MembersViewModel membersViewModel = new MembersViewModel();
            membersViewModel.Biodata = _memberRepository.AllMembers;
            return View(membersViewModel);
        }
       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
