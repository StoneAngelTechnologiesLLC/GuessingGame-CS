//John Pietrangelo 9am CIS340
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnPietrangelo5GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable created to hold a random number.
            int answer = 0;
            
            //Variable created to hold guess.
            int guess = 0;
            
            //Creates object (in this case number) of the "Random" class.
            Random number = new Random();
            
            /*Uses Random (number) object to call the "Next" method, which returns 
            a random number between the min and max numbers (1 to 10) and passes it into the method.*/
            answer = number.Next(1, 11);
            
            //Tells user the perameters of the game.
            Console.WriteLine("\n\t\t\tPick a number between 1 and 10.\n\t\t     You have 5 chances to pick correctly.\n");
            Console.Write("--------------------------------------------------------------------------------\n");
            
            //For Loop begins here.
            for (int i = 0; i < 5; i++)
            { 
                Console.Write(" Enter Guess #{0}:  ", (i+1));
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == answer)
                {
                    Console.WriteLine("\n\n\t<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n\n\t\t  You Won!!" + 
                                      "  {0} is the correct number....\n\n\t\t\tWhat do you want, a cookie?!", answer);
                    break;
                }
                
                else if (guess > answer && i < 4)
                {
                    Console.WriteLine("\n You are incorrect sir. Please, try again....  Here's a hint: Guess lower.\n");
                }

                else if (guess < answer && i < 4)
                {
                    Console.WriteLine("\n You are incorrect sir. Please, try again....  Here's a hint: Guess HIGHER. \n");
                }
                
                if (i == 3)
                {
                    Console.WriteLine("\t\t *** Last try highspeed, make it a good one! *** \n");
                }
                
                if (i == 4)
                {
                    Console.WriteLine("\n\t<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n\n\t    The answer" +
                                      " was {0}. You are the opposite of a winner!!!! \n\n \t\tYou Do Not Pass GO!!!" + 
                                      " You Do Not collect $200!!", answer);
                }
            }// For Loop ends here.

            //Pause display, to view output.
            Console.Write("\n\t\t\t   Press Any Key To Exit");
            Console.ReadKey();

        }// Main Method ends here.
    }// Program ends here.
}// Namespace ends here.
