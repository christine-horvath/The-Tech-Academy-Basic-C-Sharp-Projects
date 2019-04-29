using System;
using System.Collections.Generic;

public class Drill
{
    static void Main(string[] args)
    {
        //1.Create a one-dimensional Array of strings.Ask the user to input some text.Create a loop that goes through each string in the Array, adding the user’s text to the string.Then create a loop that prints off each string in the Array on a separate line.
        //string[] dogNames = { "Potato", "Pudge", "Dumpling", "Ravioli" };
        //Array.Resize(ref dogNames, dogNames.Length + 1);
        //Console.WriteLine("Please enter a good name for a dog.");
        //string iDogName = Console.ReadLine();
        //dogNames.SetValue(iDogName, 4);

        //for (int i = 0; i < dogNames.Length; i++)
        //{
        //    Console.WriteLine(dogNames[i]);
        //}

        //Console.ReadLine();

        //2.Create an infinite loop.

        //    int[] siblingsAges = { 25, 32, 30, 27 };

        //    for (int i = 0; i < siblingsAges.Length;)

        //    {
        //        Console.WriteLine(siblingsAges[i]);
        //    }
        //    Console.ReadLine();
        //}

        //3.Fix the infinite loop so it will execute.

        //    int[] siblingsAges = { 25, 32, 30, 27 };

        //    for (int i = 0; i < siblingsAges.Length; i++)

        //    {
        //        Console.WriteLine(siblingsAges[i]);
        //    }
        //    Console.ReadLine();
        //}

        //4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.

        //int[] graduationYears = { 1998, 1977, 1961, 2007, 2011 };

        //for (int i = 0; i < graduationYears.Length; i++)
        //{
        //    Console.WriteLine("The graduation year is " + graduationYears[i]);
        //}

        //Console.ReadLine();
        // }
        //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.

        //    int[] xValues = { 5, 6, 8, 2, 10, 99, 1 };

        //    for (int i = 0; i <= xValues.Length; i++)
        //    {
        //        Console.WriteLine(xValues[5]);         
        //    }
        //    Console.ReadLine();
        //}
        //6.Create a List of strings where each item in the list is unique.Ask the user to select text to search for in the List.Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.

        //        List<string> tvShows = new List<string>();
        //        tvShows.Add("Casual");
        //        tvShows.Add("Pen15");
        //        tvShows.Add("Shrill");
        //        tvShows.Add("Difficult People");

        //        Console.WriteLine("Enter your favorite Hulu Original comedy series to see if it made our list of favorites.");
        //        string huluShow = Console.ReadLine();

        //        foreach (string tvShow in tvShows)
        //        {
        //            if (huluShow == "Casual")
        //            {
        //                Console.WriteLine("Congratulations! Casual is one of our favorite Hulu Original comedies. It appears at index " + (tvShows.IndexOf("Casual")) + "!");
        //                break;
        //            }
        //            else if (huluShow == "Pen15")
        //            {
        //                Console.WriteLine("Congratulations! Pen15 is one of our favorite Hulu Original comedies. It appears at index " + (tvShows.IndexOf("Pen15")) + "!");
        //                break;
        //            }
        //            else if (huluShow == "Shrill")
        //            {
        //                Console.WriteLine("Congratulations! Shrill is one of our favorite Hulu Original comedies. It appears at index " + (tvShows.IndexOf("Shrill")) + "!");
        //                break;
        //            }
        //            else if (huluShow == "Difficult People")
        //            {
        //                Console.WriteLine("Congratulations! Difficult People is one of our favorite Hulu Original comedies. It appears at index " + (tvShows.IndexOf("Difficult People")) + "!");
        //                break;
        //            }

        //        }
        //        Console.ReadLine();
        //    }      
        //}

        //7.Add code to that above loop that tells a user if they put in text that isn’t in the List.

        //        List<string> tvShows = new List<string>();
        //        tvShows.Add("Casual");
        //        tvShows.Add("Pen15");
        //        tvShows.Add("Shrill");
        //        tvShows.Add("Difficult People");

        //        Console.WriteLine("Enter your favorite Hulu Original comedy series to see if it made our list of favorites.");
        //        string huluShow = Console.ReadLine();

        //        foreach (string tvShow in tvShows)
        //        {
        //            if (huluShow == "Casual")
        //            {
        //                Console.WriteLine("Congratulations! Casual is one of our favorite Hulu Original comedies. It appears at index " + (tvShows.IndexOf("Casual")) + "!");

        //            }
        //            else if (huluShow == "Pen15")
        //            {
        //                Console.WriteLine("Congratulations! Pen15 is one of our favorite Hulu Original comedies. It appears at index " + (tvShows.IndexOf("Pen15")) + "!");

        //            }
        //            else if (huluShow == "Shrill")
        //            {
        //                Console.WriteLine("Congratulations! Shrill is one of our favorite Hulu Original comedies. It appears at index " + (tvShows.IndexOf("Shrill")) + "!");

        //            }
        //            else if (huluShow == "Difficult People")
        //            {
        //                Console.WriteLine("Congratulations! Difficult People is one of our favorite Hulu Original comedies. It appears at index " + (tvShows.IndexOf("Difficult People")) + "!");

        //            }
        //            else
        //            {
        //                Console.WriteLine("We're sorry, that Hulu Original comedy didn't make our list of favorites.");

        //            }

        //        }
        //        Console.ReadLine();
        //    }
        //}

        //8.Add code to that above loop that stops it from executing once a match has been found.

        //        List<string> tvShows = new List<string>();
        //        tvShows.Add("Casual");
        //        tvShows.Add("Pen15");
        //        tvShows.Add("Shrill");
        //        tvShows.Add("Difficult People");

        //        Console.WriteLine("Enter your favorite Hulu Original comedy series to see if it made our list of favorites.");
        //        string huluShow = Console.ReadLine();

        //        foreach (string tvShow in tvShows)
        //        {
        //            if (huluShow == "Casual")
        //            {
        //                Console.WriteLine("Congratulations! Casual is one of our favorite Hulu Original comedies. It appears at index " + (tvShows.IndexOf("Casual")) + "!");
        //                break;
        //            }
        //            else if (huluShow == "Pen15")
        //            {
        //                Console.WriteLine("Congratulations! Pen15 is one of our favorite Hulu Original comedies. It appears at index " + (tvShows.IndexOf("Pen15")) + "!");
        //                break;
        //            }
        //            else if (huluShow == "Shrill")
        //            {
        //                Console.WriteLine("Congratulations! Shrill is one of our favorite Hulu Original comedies. It appears at index " + (tvShows.IndexOf("Shrill")) + "!");
        //                break;
        //            }
        //            else if (huluShow == "Difficult People")
        //            {
        //                Console.WriteLine("Congratulations! Difficult People is one of our favorite Hulu Original comedies. It appears at index " + (tvShows.IndexOf("Difficult People")) + "!");
        //                break;
        //            }
        //            else
        //            {
        //                Console.WriteLine("We're sorry, that Hulu Original comedy didn't make our list of favorites.");
        //                break;
        //            }

        //        }
        //        Console.ReadLine();
        //    }
        //}



        //9.Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List.Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.

        //    List<string> dogBreeds = new List<string>();
        //    dogBreeds.Add("Pug");
        //    dogBreeds.Add("Mutt");
        //    dogBreeds.Add("Beagle");
        //    dogBreeds.Add("Greyhound");
        //    dogBreeds.Add("Mutt");
        //    dogBreeds.Add("Pug");

        //    Console.WriteLine("Enter a dog breed to find its index or indices!");
        //    string favDog = Console.ReadLine();

        //    bool inputBreed = (favDog == "Pug" || favDog == "Mutt" || favDog == "Beagle" || favDog == "Greyhound");
        //    if (inputBreed == true && dogBreeds.IndexOf(favDog) < 2)
        //    {
        //        Console.WriteLine("The index for that breed is: " + dogBreeds.IndexOf(favDog));
        //    }

        //    else if (inputBreed == true && dogBreeds.IndexOf(favDog) > 1)
        //    {
        //        Console.WriteLine("The indices for that breed are: " + dogBreeds.IndexOf(favDog) + ", " + dogBreeds.LastIndexOf(favDog));
        //    }
        //    else
        //    {
        //        Console.WriteLine("That breed is not on the list.");
        //    }


        //    Console.ReadLine();
        //}




        //}

        //10.Add code to that above loop that tells a user if they put in text that isn’t in the List.

        // see "else" above

        //11.Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
//        List<string> streets = new List<string>();
//        streets.Add("Faith Street");
//        streets.Add("Katahdin Drive");
//        streets.Add("Neil Ave");
//        streets.Add("Fairview Ave");
//        streets.Add("Neil Ave");

//        List<string> secondList = new List<string>();
//        foreach (string street in streets)
//        {
//            if (!secondList.Contains(street))
//            {
//                secondList.Add(street);
//                Console.WriteLine(street + ": This street was not used more than once.");
//            }
//            else
//                Console.WriteLine(street + ": This street was used more than once.");
//        }
//        Console.ReadLine();
//    }
//}






