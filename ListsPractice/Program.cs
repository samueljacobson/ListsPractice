using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> favNumbers = new List<int>();
            favNumbers.Add(7);
            favNumbers.Add(25);
            favNumbers.Add(30);

            foreach(int number in favNumbers)  //to print list
            {
                Console.WriteLine(number);
            }

            //Use .Count property to get size of list
            Console.WriteLine(favNumbers.Count);


            List<string> books = new List<string> { "Cat in the Hat", "Frog and Toad", "Green Eggs and Ham" };
            Console.WriteLine(books[0]);
            books.Insert(0, "Horton Hears a Who");  //insert at index 0 (inserts at current index moving previous element down one)
            Console.WriteLine(books[0]);

            //Create a list and add 5 animals using .Add()
            //Print each animal in the list
            List<string> animals = new List<string>();
            animals.Add("lion");
            animals.Add("zebra");
            animals.Add("giraffe");
            animals.Add("tiger");
            animals.Add("narwhal");
            foreach(string animal in animals)
            {
                Console.WriteLine(animal);
            }

            //Create bool list {true,false,false,true,false}
            //Loop through each value
            //If true print "Better bring an umbrella"
            //If false print "No rain today enjoy the sun"
            List<bool> rain = new List<bool> { true, false, false, true, false };
            for (int i = 0; i < rain.Count; i++)
            {
                if (rain[i] == true)
                {
                    Console.WriteLine("Better bring an umbrella.");
                }
                else
                {
                    Console.WriteLine("No rain today, enjoy the sun.");
                }
            }

            //.Contains
            List<string> faveFoods = new List<string> { "Steak", "Fish", "Katsudon", "Ice cream", "Nachos" };
            if(faveFoods.Contains("Fish"))
            {
                Console.WriteLine("I like fish too!");
            }

            //Create a list with the following numbers: 1 23 9 77 922 6 32 63 14 5
            //Use the contains method with the following values: 23 77 15
            //Remove these elements: 23 77 32 6 (.Remove method)
            //Use contains again on these values: 23 77 15
            List<int> numbers = new List<int> { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            Console.WriteLine(numbers.Contains(23));
            Console.WriteLine(numbers.Contains(77));
            Console.WriteLine(numbers.Contains(15));
            numbers.Remove(23);
            numbers.Remove(77);
            numbers.Remove(32);
            numbers.Remove(6);
            Console.WriteLine(numbers.Contains(23));
            Console.WriteLine(numbers.Contains(77));
            Console.WriteLine(numbers.Contains(15));

            //Ask the user for a movie, if not in list add and inform user it has been ordered
            //If the movie is in list inform that it is on the way
            //If user enters quit the program should exit
            //The user should be able to add as many movies as they want
            //When the user quits show them all of the movies being ordered
            List<string> movies = new List<string> { "Office Space", "The Big Lebowski", "Pulp Fiction", "Amadeus", "Rushmore" };
            string movieEntry;
            do
            {
                Console.WriteLine("Please enter the movie you would like to order.");
                Console.WriteLine("You may enter \"quit\" when finished.");
                movieEntry = Console.ReadLine();
                if (movieEntry.ToLower() == "quit")
                {
                    Console.WriteLine("Thank you for your order! You will be receiving the following:");
                    foreach(string movie in movies)
                    {
                        Console.WriteLine(movie);
                    }
                }
                else if (movies.Contains(movieEntry))
                {
                    Console.WriteLine(movieEntry + " is in stock and on the way!");
                }
                else
                {
                    Console.WriteLine(movieEntry + " has been ordered and will available in 3-5 days.");
                    movies.Add(movieEntry);
                }
            }
            while (movieEntry.ToLower() != "quit");
        }
    }
}
