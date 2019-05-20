
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
        public ActionResult Quote(string firstname, string lastName, string emailAddress, DateTime dateOfBirth, int carYear, string carMake, string carModel, bool hasDUI, double? numberofTickets, bool fullCoverage)
        {
            Convert.ToDouble(numberofTickets);

            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel))
            {
                return View("~Views/Shared/Error.cshtml");
            }
            else
            {
                double? quote = 50;
                var today = DateTime.Today;
                int age = today.Year - dateOfBirth.Year;
                


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
                if (hasDUI == true)
                {
                    quote *= 1.25;

                }
                //----------------------------------------------
                if (fullCoverage == true)
                {
                    quote *= 1.5;
                }

                using (quoteGen2Entities1 db = new quoteGen2Entities1())
                {
                    
                    var driverdata = new driverData();
                    driverdata.FirstName = firstname;
                    driverdata.LastName = lastName;
                    driverdata.EmailAddress = emailAddress;
                    driverdata.BirthDate = dateOfBirth;
                    driverdata.CarYear = carYear;
                    driverdata.CarMake = carMake;
                    driverdata.CarModel = carModel;
                    driverdata.HasDUI = hasDUI;
                    driverdata.NumberOfTickets = numberofTickets;
                    driverdata.FullCoverage = fullCoverage;
                    driverdata.Quote = Convert.ToInt32(quote); 

                    db.driverDatas.Add(driverdata);
                    db.SaveChanges();

                    //var quotees = (from c in db.driverDatas
                    //                  where c.EmailAddress == emailAddress
                    //                  select c).ToList();
                    //var quoteeVms = new List<QuoteReturnVM>();
                    //foreach (var quotee in quotees)
                    //{
                    //    var quoteeVm = new QuoteReturnVM();
                    //    quoteeVm.Id = quotee.Id;
                    //    quoteeVm.Firstname= quotee.FirstName;
                    //    quoteeVm.LastName = quotee.LastName;
                    //    quoteeVm.EmailAddress = quotee.EmailAddress;
                    //    quoteeVm.Quote = quotee.Quote;
                    //    quoteeVms.Add(quoteeVm);
                            
                    //}

                    return View(driverdata);                    
                } 
            }        
        }
        //public ActionResult Quote(int Id)
        //{
        //    using (quoteGenEntities db = new quoteGenEntities())
        //    {
        //        var applicant = db.driverDatas.Find(Id);
        //    }
        //    return RedirectToAction("Success");
        //}
    }
}

    