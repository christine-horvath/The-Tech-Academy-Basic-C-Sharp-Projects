
using quoteGeneratorX.Models;
using quoteGeneratorX.ViewModels;
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

            using (quoteGen2Entities1 db = new quoteGen2Entities1())
            {
                var applicants = (from c in db.driverDatas
                                  where c.Id < 1000
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
            using (quoteGen2Entities1 db = new quoteGen2Entities1())
            {
                var applicant = db.driverDatas.Find(Id);
                applicant.Id = Id;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}