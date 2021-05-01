using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistrationForm1.Models;

namespace RegistrationForm1.Controllers
{
    public class textController : Controller
    {
        // GET: text
        public ActionResult Index()
        {
            employe e1 = new employe { empid = 121, empname = "sunita", empemail = "sunitalakade55", emppassword = "121212", empmobile = "2147542873", empaddress = "pune" };

            return View(e1);
        }
    }
}