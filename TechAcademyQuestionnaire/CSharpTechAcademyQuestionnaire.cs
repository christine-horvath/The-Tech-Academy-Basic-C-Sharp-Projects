using System;


namespace Test2
{
    class CSharpTechAcademyQuestionnaire
    {
        static void Main(string[] args)
        {
            //console.writeline("what is your name?");
            //string yourname = console.readline();
            //console.writeline("your name is: " + yourname);
            //console.readline();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            //bool isStudying = false;
            //byte hoursWorkes = 42;
            //char middleInitial = 'M';
            //char questionMark = '\u2103';

            string answer;
            bool needHelp = false;

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
                string courseTitle = Console.ReadLine();
            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            int pageNo = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? Please answer true/false.");
            answer = Console.ReadLine().ToLower();
            answer.Trim();
            if (answer == "true")
            {
                needHelp = true;
            }
           

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int hoursStud = Convert.ToInt32(hoursStudied);
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();





        }
    }
}
