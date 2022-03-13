using FBKsystem.Models;
using FBKsystem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FBKsystem.Controllers
{
    public class MemberController : Controller
    {
        private readonly IBiodataRepository _memberRepository;
        public MemberController(IBiodataRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }
        public IActionResult Dashboard()
        {

            //var LoggedInUser = _memberRepository.GetMemberById(Id);
            //if (LoggedInUser == null)
            //    return NotFound();
            //return View(LoggedInUser);
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PaidDues()
        {
            return View();
        }
        public IActionResult PayDues()
        {
            return View();
        }
        public IActionResult UpdateBio()
        {

            return View();
            
        }
       
        [HttpPost]
        public IActionResult UpdateBio(Biodata member)
        {
            _memberRepository.UpdateBio(member);
            return RedirectToAction("Index");
        }
        //[HttpPost]
        //public IActionResult createMember(Member member)
        //{
           
        //        _memberRepository.CreateMember(member);
        //        return RedirectToAction("success");
           
        //}
        public IActionResult success()
        {
            ViewBag.memberAddSuccessMsg = "New Member Added successfully";
            return View();        
        }
        public RedirectToActionResult Logout()
        {
            return RedirectToAction("Index");
        }
        public IActionResult UpdateSocialMedia()
        {
            return View();
        }
         
    }
}
