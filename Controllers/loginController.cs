using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PLREPORT.Models;

namespace PLREPORT.Controllers
{
    public class loginController : Controller
    {
        ILogger<loginController> _logger;
        public loginController(ILogger<loginController> logger)
        {
            _logger = logger;
        }

       public IActionResult Index()
       {
           return View();
       }

       public IActionResult login()
       {
            login _data = new login();
           _data.id = "BEAM";
            return View(_data);
       }
    }
}