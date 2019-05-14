using QuoteGen.Models;
using QuoteGen.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace quotegen.controllers
{
    public class quotecontroller : Controller
    {

        // get: quote
        public ActionResult Index()
        {
            return View();
        }
        // do i need to keep these or condense?
        [HttpPost]
        public ActionResult driverData(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, int carYear, string carMake, string carModel, bool duiradio, int numberofTickets, bool fullcovradio)
        {
            double quote = 50;
            var today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;

            using (quoteGeneratorEntities db = new quoteGeneratorEntities())
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
            if (carMake == "Porsche")
            {
                //add "to lower"
                quote += 25;
            }

            //--------------------------------------------
            if (carMake == "Porsche" && carModel == "911 Carrera")
            {

                quote += 25;
            }

            //----------------------------------------------
            if (numberofTickets > 0)
            {
                quote += (numberofTickets * 10);
            }
            //----------------------------------------------
            if (duiradio == true)
            {
                quote *= 1.25;
 
            }   

            //----------------------------------------------
            if (fullcovradio == true)
            {
                quote *= 1.5;
            }

            //------------------------------------------------

            //using (quoteGeneratorEntities db = new quoteGeneratorEntities())
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
 

                }
                return View("Quote");
            }
        }
    }
