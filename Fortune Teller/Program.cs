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

            //Warning it may not be the prettiest or cleanist code but forgive my newb-ness i'm still learning'

            Console.WriteLine("\n");
            Console.WriteLine("Let's get this party started! I am the Great Fortune Teller FaizeChan! \nWhat's your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Well Hello" + " " + firstName + "! What's your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Very unique in my book. What's your age?");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Oh you're" + " " + userAge + " " + "That's wassup, but I'm a little curious... \nIn number form, what's your birthday month?");
            int birthMonth = int.Parse(Console.ReadLine());
            int one = 1;
            int two = 2;
            int three = 3;
            int four = 4;
            int five = 5;
            int six = 6;
            int seven = 7;
            int eight = 8;
            int nine = 9;
            int ten = 10;
            int eleven = 11;
            int twelve = 12;            

            Console.WriteLine("\n");

            Console.WriteLine("Aye Turn Up! What's your favorite ROYGBIV color? \nIf you don't know the ROYGBIV colors just enter (help)");
            string favColor = Console.ReadLine().ToLower().Trim();
            string userHelp = "help";
            Console.WriteLine("\n");

            if (favColor == userHelp)
            {
                Console.WriteLine("Aye that's fine. ROYGBIV is the following colors. \nRed \nOrange \nYellow \nGreen \nBlue \nIndigo \nViolit \n \nAlright so now which one of these colors is your favorite one?");
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
            //When did the Fortune Teller FaizeChan turn into a wizard from Hogwarts???

            else if (readyUp == disagree)
            {
                Console.WriteLine("\nI said you don't have a choice! You're getting your fortune otherwise \nI don't get paid!");
            }
            else 
            {
                Console.WriteLine("That's not one of the flipping options. Don't be scared of your fortune \nWell since you didnt say no here's your fortune anyways hahaha!");
            }
            Console.WriteLine("\n");
            if(userAge%2==0)
            {
                Console.WriteLine("Your name is" + " " + firstName + " " + lastName + " " + "and you will retire in 20 years pretty decent.");
            }
            else
            {
                Console.WriteLine("Your name is" + " " + firstName + " " + lastName + " " + "and you will retire in 15 years Nice!");
            }
             //I know there is an easier way to do all this but I don't know it so for now I'm going to stick with the hard way because it's working     
             
            if (birthMonth == one)
            {
                Console.WriteLine("Ooooo, you will also have a staggering amount of 2 Million dollars in the bank");
            }
            else if (birthMonth == two)
            {
                Console.WriteLine("Ooooo, you will also have a staggering amount of 2 Million dollars in the bank");
            }
            else if (birthMonth == three)
            {
                Console.WriteLine("Ooooo, you will also have a staggering amount of 2 Million dollars in the bank");
            }
            else if (birthMonth == four)
            {
                Console.WriteLine("Ooooo, you will also have a staggering amount of 2 Million dollars in the bank");
            }
            else if (birthMonth == five)
            {
                Console.WriteLine("Pretty nice, you will also have a wopping amount of $500,000.00 in the bank");
            }
            else if (birthMonth == six)
            {
                Console.WriteLine("Pretty nice, you will also have a wopping amount of $500,000.00 in the bank");
            }
            else if (birthMonth == seven)
            {
                Console.WriteLine("Pretty nice, you will also have a wopping amount of $500,000.00 in the bank");
            }
            else if (birthMonth == eight)
            {
                Console.WriteLine("Pretty nice, you will also have a wopping amount of $500,000.00 in the bank");
            }
            else if (birthMonth == nine)
            {
                Console.WriteLine("You will also have a deceant amount of $20,000.00 in the bank");
            }
            else if (birthMonth == ten)
            {
                Console.WriteLine("You will also have a deceant amount of $20,000.00 in the bank");
            }
            else if (birthMonth == eleven)
            {
                Console.WriteLine("You will also have a deceant amount of $20,000.00 in the bank");
            }
            else if (birthMonth == twelve)
            {
                Console.WriteLine("You will also have a deceant amount of $20,000.00 in the bank");
            }
            else
            {
                Console.WriteLine("tsk tsk... but sadly you will have $0.00 in the bank");
            }



        }
    }
}