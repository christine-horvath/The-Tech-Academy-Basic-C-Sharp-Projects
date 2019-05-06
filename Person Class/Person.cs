using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Class
{
    public class Person
    {

        //first name, last name
        public List<string> FullName { get; set; }
        public List<string> FirstName { get; set; }
        public List<string> LastName { get; set; }

        //string firstname = "Sample";
        //string lastname = "Student";

        public void SayName()
        {
            foreach (string firstname in FirstName)
            {
                foreach (string lastname in LastName)
                {

                    Console.WriteLine("Name: [" + firstname + " " + lastname + "]");

                }
            }
        }
    }
}
