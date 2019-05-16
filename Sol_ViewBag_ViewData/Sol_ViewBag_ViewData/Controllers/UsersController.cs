using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_ViewBag_ViewData.Models;

namespace Sol_ViewBag_ViewData.Controllers
{
    public class UsersController : Controller
    {
        [BindProperty]
        public UserModel Users { get; set; }

        public IActionResult Index()
        {
            Users = new UserModel()
            {
                FirstName = "Kishor",
                LastName = "Naik"
            };

            // Using ViewData
            this.ViewData["UserModelData"] = Users;  // Bind User Model Data into ViewData
            this.ViewData["Data"] = "Kishor Naik";

            // Using ViewBag
            this.ViewBag.UserModelObj = Users; // Bind User Model Data into ViewBag [UserModelObj is dynamic property]

            return View();
        }
    }
}