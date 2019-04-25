using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   namespace String_Project
   {
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //string name = "Christine";
//            //string quote = "The man said, \\Hello\" Christine. \n Hello on a new line \n \t Hello on a tab.";
//            //string fileName = @"C:\Users\Jesse";

//            //bool trueOrFalse = name.Contains("s");
//            ////reassign variable
//            //trueOrFalse = name.EndsWith("s");
//            //Console.WriteLine(trueOrFalse);
//            //Console.ReadLine();

//            //StringBuilder sb = new StringBuilder();
//            //sb.Append("My name is Christine.");
//            //Console.WriteLine(sb);
//            //Console.ReadLine();

//            //Concatenate three strings.

//            //Convert a string to uppercase.

//            //Create a Stringbuilder and build a paragraph of text, one sentence at a time.

//            //string name = "Tig Notaro ";
//            //string isMy = "is my ";
//            //string favCom = "favorite comedian.";

//            //Console.WriteLine(name + isMy + favCom);
//            //Console.ReadLine();

//            //string presentsA = "now please make some noise for your headliner, chelsea handler!";
//            //presentsA = presentsA.ToUpper();
//            //Console.WriteLine(presentsA);
//            //Console.ReadLine();


//        }
//    }


    public sealed class APP
    {
        static void Main()
        {

            string paragraphA = "Ever since I was young, I wanted to be a comedian. ";
            StringBuilder sb = new StringBuilder(paragraphA);
            sb.Append("After a bad breakup in 2012, I decided to try stand up. ");
            sb.Append("It was somewhat terrifying, but I am happy I did it! ");
            sb.Append("Now I can't imagine my life without stand-up.");
        
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}