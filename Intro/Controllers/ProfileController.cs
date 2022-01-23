using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Intro.Models.ViewModels;

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
            //якщо реєстрація успішна - перенаправити корстувача в його акаунт
            if (ModelState.IsValid)
            {
                //TODO: Register User
                //TODO: Login User
                //Якщо реєстрація успішна - перенаправити користувача в його акаунт
                return RedirectToAction("Account");
            }
            else
            {
                return View(newUser);
            }
        }

        public ViewResult Account()
        {
            return View();
        }

    }
}