using FBKsystem.Models;
using FBKsystem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FBKsystem.Controllers
{
    public class AdminController : Controller
    {
        private readonly IExecutiveRepository _executiveRepository;
        private readonly IBiodataRepository _MemberRepository;
        public AdminController(IExecutiveRepository executiveRepository, IBiodataRepository MemberRepository)
        {
            _executiveRepository = executiveRepository;
            _MemberRepository = MemberRepository;
        }
        public IActionResult CreateExecutive()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult profile()
        {
            return View();
        }
        public IActionResult AllDues()
        {
            return View();
        }
        public IActionResult AllExecutives()
        {
            return View();
        }
        public IActionResult members()
        {
            MembersViewModel memberViewModel = new MembersViewModel();
            memberViewModel.Biodata = _MemberRepository.AllMembers;
            return View(memberViewModel.Biodata);
        }
        public IActionResult Dinner()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExecutive(Executive executive)
        {

            _executiveRepository.CreateExecutive(executive);
            return RedirectToAction("Success");

        }
        public IActionResult success()
        {
            ViewBag.memberAddSuccessMsg = "New Executive Added successfully";
            return View();
        }
    }
}
