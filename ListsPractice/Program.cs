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
    }
    }
}
