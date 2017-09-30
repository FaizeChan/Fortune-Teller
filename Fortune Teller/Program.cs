using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Let's get this party started! I am the Great Fortune Teller FaizeChan! \nWhat's your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Wow, nice name! You're doing Great! What's your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Very unique in my book. What's your age?");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Oh you're" + " " + userAge + " " + "That's wassup, but I'm a little curious... \nIn number form, what's your birthday month?");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Aye Turn Up! What's your favorite ROYGBIV color? \nIf you don't know the ROYGBIV colors just enter (help)");
            string favColor = Console.ReadLine().ToLower().Trim();
            string userHelp = "help";
            Console.WriteLine("\n");
            if (favColor == userHelp)
            {
                Console.WriteLine("Aye that's fine. ROYGBIV is the following colors. \nRed \nOrange \nYellow \nGreen \nBlue \nIndigo \nViolit \nAlright so now which one of these colors is your favorite one?");
                favColor = Console.ReadLine();
                Console.WriteLine("\n");
            }

            Console.WriteLine("Interesting indeed! How many siblings do you have?");
            int siblingNum = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPerfect, I believe I have enough information to declare your fortune!\nAre you ready? Not like you have a choice in the matter Mwahaha \nType in either(Yes, or No)");
            string readyUp = Console.ReadLine().ToLower().Trim();
            string agree = "yes";
            string disagree = "no";
            Console.WriteLine();
            if (readyUp == agree)
            {
                Console.WriteLine("\nExpectooo Patronum!!");
            }
            else if (readyUp == disagree)
            {
                Console.WriteLine("\nI said you don't have a choice! You're getting your fortune otherwise \nI don't get paid!");
            }
            else 
            {
                Console.WriteLine("That's not one of the flipping options. Don't be scared of your fortune \nWell since you didnt say no here's your fortune anyways hahaha!");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Your name is" + " " + firstName + " " + lastName + ".");
            if(userAge%2==0)
            {
                Console.WriteLine("You will retire in 20 years pretty decent.");
            }
            else
            {
                Console.WriteLine("You will retire in 15 years Nice!");
            }
                    
        }
    }
}