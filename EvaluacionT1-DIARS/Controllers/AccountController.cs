using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EvaluacionT1_DIARS.Controllers
{
    public class AccountController : Controller
    {
        
        public ActionResult Index()
        {
            //ViewBag.Accounts = _contexto.Accounts.ToList();
            return View();
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

    }
}
