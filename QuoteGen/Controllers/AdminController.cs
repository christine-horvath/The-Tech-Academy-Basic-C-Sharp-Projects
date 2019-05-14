using QuoteGen.Models;
using QuoteGen.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuoteGen.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {

            using (quoteGeneratorEntities db = new quoteGeneratorEntities())
            {
                var applicants = (from c in db.driverDatas
                                  where c.Quote != null
                                  select c).ToList();
                var applicantVms = new List<ApplicantVM>();
                foreach (var applicant in applicants)
                {
                    var applicantVm = new ApplicantVM();
                    applicantVm.Id = applicant.Id;
                    applicantVm.Firstname = applicant.FirstName;
                    applicantVm.LastName = applicant.LastName;
                    applicantVm.EmailAddress = applicant.EmailAddress;
                    applicantVms.Add(applicantVm);
                }
                return View(applicantVms);
            }
        }
        public ActionResult Quote(int Id)
        {
            using (quoteGeneratorEntities db = new quoteGeneratorEntities())
            {
                var applicant = db.driverDatas.Find(Id);
                applicant.Quote = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}