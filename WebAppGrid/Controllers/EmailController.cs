using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppGrid.Models;

namespace WebAppGrid.Controllers
{
    public class EmailController : Controller
    {
        public List<EmailAddress> distributionList;

        public EmailController() {
            distributionList = new List<EmailAddress>()
            {
                new EmailAddress("sklok11@gmail.com", true, "Serge", "Klokov"),
                new EmailAddress("dune@dog.org"),
            };
        }

        public ActionResult Index()
        {
            return View(distributionList);
        }
    }
}