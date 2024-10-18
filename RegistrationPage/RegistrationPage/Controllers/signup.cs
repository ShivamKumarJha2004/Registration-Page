using Microsoft.AspNetCore.Mvc;

using RegistrationPage.Models;
using RegistrationPage.services;
using System.Collections.Generic;

namespace RegstrationPage.Controllers
{
    public class signup : Controller
    {

        private static List<User> _users = new List<User>();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                _users.Add(user);
                TempData["SuccessMessage"] = "Data inserted successfully!";
                return RedirectToAction("index");
            }
            return View(user);

        }
        [HttpGet]
        public IActionResult signupsuccess()
        {
            return View(_users);
        }


    }
}

