using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace quoteGeneratorX.ViewModels
{
    public class QuoteReturnVM
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int Quote { get; set; }
    }
}