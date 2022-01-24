using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Intro.Models.ViewModels;
using Intro.Models.Entities;

namespace Intro.Controllers
{
    public class ProfileController : Controller
    {
        //Видає форму реєстрації через Get-запит
        public ViewResult Register()
        {
            VM_UserRegister vM_UserRegister = new VM_UserRegister();

            return View(vM_UserRegister);
        }
        //приймає форму реєстрації через POST-запит
        [HttpPost]
        public ActionResult Register(VM_UserRegister newUser)
        {
            if (ModelState.IsValid)
            {                          
                User user = new User
                {
                    Name = newUser.Name,
                    Email = newUser.Email
                };

                return RedirectToAction("Account", user);
            }
            else
            {
                return View(newUser);
            }
        }

        public ViewResult Account(User user)
        {
            return View(user);
        }

    }
}