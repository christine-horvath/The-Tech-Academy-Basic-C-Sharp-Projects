using QuoteGen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuoteGen.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult driverData(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, int carYear, string carMake, string carModel, bool duiradio, int numberofTickets, bool fullcovradio)
        {

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel))
            {
                return View("~Views/Shared/Error.cshtml");
            }
            else
            {
                using (quoteGeneratorEntities db = new quoteGeneratorEntities())
                {
                    var driverdata = new driverData();
                    driverdata.FirstName = firstName;
                    driverdata.LastName = lastName;
                    driverdata.EmailAddress = emailAddress;
                    driverdata.DateOfBirth = dateOfBirth;
                    driverdata.CarYear = carYear;
                    driverdata.CarMake = carMake;
                    driverdata.CarModel = carModel;
                    driverdata.DuiRadio = duiradio;
                    driverdata.NumberOfTickets = numberofTickets;
                    driverdata.FullCovRadio = fullcovradio;
                    
                    db.driverDatas.Add(driverdata);
                    db.SaveChanges();
                }

                return View("Quote");
            }
        }
    }
}