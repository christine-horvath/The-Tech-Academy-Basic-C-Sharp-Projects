using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace quoteGeneratorX.ViewModels
{
    public class ApplicantVM
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int Id { get; set; }
        public int Quote { get; internal set; }
    }
}