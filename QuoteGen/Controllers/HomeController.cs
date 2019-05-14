
using quoteGeneratorX.Models;
using quoteGeneratorX.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace quoteGeneratorX.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult driverData(string firstname, string lastName, string emailAddress, DateTime dateOfBirth, int carYear, string carMake, string carModel, string duiradio, int numberofTickets, string fullcovradio)
        {

            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel))
            {
                return View("~Views/Shared/Error.cshtml");
            }
            else
            {
                double quote = 50;
                var today = DateTime.Today;
                int age = today.Year - dateOfBirth.Year;
                var dui = Convert.ToBoolean(duiradio);
                var fullcov = Convert.ToBoolean(fullcovradio);

                //----------------------------------
                if (age < 25)
                {
                    quote += 25;
                }
                else if (age < 18)
                {
                    quote += 100;
                }
                else if (age > 100)
                {
                    quote += 25;

                }
                //----------------------------------------------
                if (carYear < 2000)
                {
                    quote += 25;
                }

                //---------------------------------------------
                if (carMake.ToLower() == "porsche")
                {
                    //add "to lower"
                    quote += 25;
                }

                //--------------------------------------------
                if (carMake.ToLower() == "porsche" && carModel.ToLower() == "911 carrera")
                {

                    quote += 25;
                }

                //----------------------------------------------
                if (numberofTickets > 0)
                {
                    quote += (numberofTickets * 10);
                }
                //----------------------------------------------
                if (dui == true)
                {
                    quote *= 1.25;

                }

                //----------------------------------------------
                if (fullcov == true)
                {
                    quote *= 1.5;
                }


                using (quoteGen2Entities db = new quoteGen2Entities())
                {
                    var driverdata = new driverData();
                    driverdata.FirstName = firstname;
                    driverdata.LastName = lastName;
                    driverdata.EmailAddress = emailAddress;
                    driverdata.DateOfBirth = dateOfBirth;
                    driverdata.CarYear = carYear;
                    driverdata.CarMake = carMake;
                    driverdata.CarModel = carModel;
                    driverdata.HasDUI = dui;
                    driverdata.NumberOfTickets = numberofTickets;
                    driverdata.FullCoverage = fullcov;
                    driverdata.Quote = Convert.ToInt32(quote);

                    db.driverDatas.Add(driverdata);
                    db.SaveChanges();

                    var applicants = (from c in db.driverDatas
                                      where c.Quote >= 50
                                      select c).ToList();
                    var applicantVms = new List<ApplicantVM>();
                    foreach (var applicant in applicants)
                    {
                        var applicantVm = new ApplicantVM();
                        applicantVm.Firstname = applicant.FirstName;
                        applicantVm.LastName = applicant.LastName;
                        applicantVm.EmailAddress = applicant.EmailAddress;
                        applicantVm.Quote = applicant.Quote;
                        applicantVms.Add(applicantVm);
                    }
                    return View(applicantVms);                    
                } 
            }        
        }
        public ActionResult Quote(int Id)
        {
            using (quoteGen2Entities db = new quoteGen2Entities())
            {
                var applicant = db.driverDatas.Find(Id);
            }
            return RedirectToAction("Quote");
        }
    }
}

    