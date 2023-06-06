using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
                new EmailAddress(1,"sklok11@gmail.com", true, "Serge", "Klokov"),
                new EmailAddress(2,"dune@dog.org"),
            };
        }

        public ActionResult Index()
        {
            return View(distributionList);
        }

        public ActionResult Edit(int id) {
            EmailAddress model = distributionList.FirstOrDefault(x => x.ID == id);

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(EmailAddress model)
        {
            var m = distributionList.FirstOrDefault(x => x.ID == model.ID);
            m.Email = model.Email;
            m.LastName = model.LastName;
            m.FirstName = model.FirstName;
            m.Active= model.Active;
            m.Comment= model.Comment;

            return RedirectToAction("Index");
            //return RedirectToAction("Index", distributionList);
        }

    }

}