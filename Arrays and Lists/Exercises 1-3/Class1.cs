using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysandlists2
{
    class Program
    {
        static void Main(string[] args)
        {
            { //4.Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.

                List<string> willFerrellMovie = new List<string>();
                Console.WriteLine("Which Will Ferrell movie should we watch? Select a number between 1-3.");
                willFerrellMovie.Add("Anchorman");
                willFerrellMovie.Add("Step Brothers");
                willFerrellMovie.Add("Old School");
                int fourthInput = Convert.ToInt32(Console.ReadLine());
                bool indexA = fourthInput == 0;


                do
                {
                    switch (fourthInput)
                    {
                        case 1:
                            Console.WriteLine(willFerrellMovie[0]);
                            break;
                        case 2:
                            Console.WriteLine(willFerrellMovie[1]);
                            break;
                        case 3:
                            Console.WriteLine(willFerrellMovie[2]);
                            break;
                    }

                }
                while (fourthInput == 0);

                Console.ReadLine();

            }
        }
    }
}
