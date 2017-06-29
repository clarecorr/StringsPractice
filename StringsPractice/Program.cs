using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Clare";
            //int lengthOfName = firstName.Length;
            //Console.WriteLine(firstName);
            //Console.WriteLine(lengthOfName);

            //string quote = "\"Quote\" - ";
            //Console.WriteLine(quote);

            //string escapeString = "I want a tab after this line \t I want a new line withouth WriteLine \n Hi";
            //string escapeString2 = "I want to show a backslash here \\ Hey what's that noise? \a";
            //Console.WriteLine(escapeString);
            //Console.WriteLine(escapeString2);

            //Console.WriteLine("User One, input something");
            //string userOneInput = Console.ReadLine();
            //Console.WriteLine("User Two, input something");
            //string userTwoInput = Console.ReadLine();

            //if(userOneInput == userTwoInput)
            //{
            //    Console.WriteLine("Inputs are the same");
            //}
            //else
            //{
            //    Console.WriteLine("Not same");
            //}

            //if(userOneInput.Equals(userTwoInput))
            //{
            //    Console.WriteLine("Inputs are the same");
            //}

            //string startOfSentence = "My best friend's name is ";
            //string endOfSentence = "Carolyn.";
            //string fullSentence = startOfSentence + endOfSentence;

            //Console.WriteLine(startOfSentence + endOfSentence);
            //Console.WriteLine(fullSentence);

            //Console.WriteLine("My friend " + endOfSentence + " has a cute kid.");
            //Console.WriteLine("My friend {0} has a cute kid.", endOfSentence);
            //Console.WriteLine("The first part of my sentence was {0}, the second was {1}", startOfSentence, endOfSentence);

            //Console.WriteLine("This is a tab \t.\nThis is a backspace \\.\nThis is a bell sound\a.");

            //Console.WriteLine("Enter your first name");
            //string firstName = Console.ReadLine();
            //int lengthOfFirst = firstName.Length;
            //Console.WriteLine("The length of your first name is " + lengthOfFirst);
            //Console.WriteLine("Enter your last name");
            //string lastName = Console.ReadLine();
            //int lengthOfLast = lastName.Length;
            //Console.WriteLine("The length of your last name is " + lengthOfLast);

            //if(lengthOfFirst > lengthOfLast)
            //{
            //    Console.WriteLine("First is longer!");
            //}
            //else if(lengthOfFirst == lengthOfLast)
            //{
            //    Console.WriteLine("Samsies!");
            //}
            //else
            //{
            //    Console.WriteLine("last must be longer!");
            //}

            Console.WriteLine("Enter a person's name");
            string nameOne = Console.ReadLine();
            Console.WriteLine("Enter another person's name");
            string nameTwo = Console.ReadLine();
            
            //if(nameOne == nameTwo)
            //{
            //    Console.WriteLine("The names are the same");
            //}
            //else
            //{
            //    Console.WriteLine("The names are different");
            //}

            if(nameOne.Equals(nameTwo))
            {
                Console.WriteLine("The names are the same");
            }
            else
            {
                Console.WriteLine("The names are different");
            } 

            
        }
    }
}
