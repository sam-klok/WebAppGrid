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
        public EmailController() {
            if (System.Web.HttpContext.Current.Session["DistributionList"] == null)
            {
                var distributionList = new List<EmailAddress>()
                {
                    new EmailAddress(1,"sklok11@gmail.com", true, "Serge", "Klokov"),
                    new EmailAddress(2,"dune@dog.org"),
                };

                System.Web.HttpContext.Current.Session["DistributionList"] = distributionList;
            }
        }

        public ActionResult Index()
        {
            List<EmailAddress> dl = (List<EmailAddress>)Session["DistributionList"];

            return View(dl);
        }

        public ActionResult Create()
        {
            var model = new EmailAddress();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(EmailAddress model)
        {
            List<EmailAddress> dl = (List<EmailAddress>)Session["DistributionList"];
            dl.Add(model);

            Session["DistributionList"] = dl;
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            List<EmailAddress> dl = (List<EmailAddress>)Session["DistributionList"];
            EmailAddress model = dl.FirstOrDefault(x => x.ID == id);

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(EmailAddress model)
        {
            List<EmailAddress> dl = (List<EmailAddress>)Session["DistributionList"];
            EmailAddress m = dl.FirstOrDefault(x => x.ID == model.ID);

            m.Email = model.Email;
            m.LastName = model.LastName;
            m.FirstName = model.FirstName;
            m.Active = model.Active;
            m.Comment = model.Comment;

            Session["DistributionList"] = dl;

            return RedirectToAction("Index");
        }

        // GET: Email/Delete/5
        public ActionResult Delete(int id)
        {
            var dl = (List<EmailAddress>)Session["DistributionList"];
            EmailAddress model = dl.FirstOrDefault(x => x.ID == id);
            return View(model);
        }

        // POST: Email/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var dl = (List<EmailAddress>)Session["DistributionList"];
                EmailAddress model = dl.FirstOrDefault(x => x.ID == id);
                dl.Remove(model);
                Session["DistributionList"] = dl;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }

}