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
            string colorRed = "red";
            string colorOrange = "orange";
            string colorYellow = "yellow";
            string colorGreen = "green";
            string colorBlue = "blue";
            string colorIndigo = "indigo";
            string colorViolit = "violit";
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
            int siblingZero = 0;
            int siblingOne = 1;
            int siblingTwo = 2;
            int siblingThree = 3;

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
                Console.WriteLine("Ooooo, you will also have a staggering amount of $10,000,000.00 in the bank,");
            }
            else if (birthMonth == two)
            {
                Console.WriteLine("Ooooo, you will also have a staggering amount of $10,000,000.00 in the bank,");
            }
            else if (birthMonth == three)
            {
                Console.WriteLine("Ooooo, you will also have a staggering amount of $10,000,000.00 in the bank,");
            }
            else if (birthMonth == four)
            {
                Console.WriteLine("Ooooo, you will also have a staggering amount of $10,000,000.00 in the bank,");
            }
            else if (birthMonth == five)
            {
                Console.WriteLine("Pretty nice, you will also have a wopping amount of $500,000.00 in the bank,");
            }
            else if (birthMonth == six)
            {
                Console.WriteLine("Pretty nice, you will also have a wopping amount of $500,000.00 in the bank,");
            }
            else if (birthMonth == seven)
            {
                Console.WriteLine("Pretty nice, you will also have a wopping amount of $500,000.00 in the bank,");
            }
            else if (birthMonth == eight)
            {
                Console.WriteLine("Pretty nice, you will also have a wopping amount of $500,000.00 in the bank,");
            }
            else if (birthMonth == nine)
            {
                Console.WriteLine("You will also have a deceant amount of $20,000.00 in the bank,");
            }
            else if (birthMonth == ten)
            {
                Console.WriteLine("You will also have a deceant amount of $20,000.00 in the bank,");
            }
            else if (birthMonth == eleven)
            {
                Console.WriteLine("You will also have a deceant amount of $20,000.00 in the bank,");
            }
            else if (birthMonth == twelve)
            {
                Console.WriteLine("You will also have a deceant amount of $20,000.00 in the bank,");
            }
            else
            {
                Console.WriteLine("tsk tsk... but sadly you will have $0.00 in the bank,");
            }

            if (siblingNum == siblingZero)
            {
                Console.WriteLine("a vacation home in Hawaii, you're so lucky");
            }
            else if (siblingNum == siblingOne)
            {
                Console.WriteLine("a vacation home in California pretty cool");
            }
            else if (siblingNum == siblingTwo)
            {
                Console.WriteLine("a vacation home in Orlando Florida, wait a minute... Isn't that Disney World? Oh wow you're lucky");
            }
            else if (siblingNum >= siblingThree) 
            {
                Console.WriteLine("a vacation home in Tokeyo! I want to go! Take me with you!!");
            }
            else
            {
                Console.WriteLine("uhmm yeah, sorry to say but your vacation home is going to be in your mothers basement" + "BAD vacation home indeed");
            }

            if (favColor == colorRed)
            {
                Console.WriteLine("Oh yeah! You'll also be riding in a luxury Escalade. Living the fancy life I see.");
            }
            else if (favColor == colorOrange)
            {
                Console.WriteLine("Also you'll be riding in a soccor mom van. Hey, I don't come up with the fortunes. I just tell them to you.");
            }
            else if (favColor == colorYellow)
            {
                Console.WriteLine("Wow... \n \nThis is a big one. You'll be cruising in an actual cruise ship, and it's all yours. Congrats!!");
            }
            else if (favColor == colorGreen)
            {
                Console.WriteLine("Hold up... \n \n OMG... \n \n You will own your own airline!!! It will be called (" + firstName + " " + "Takes Flight!) Congrats!!");
            }
            else if (favColor == colorBlue)
            {
                Console.WriteLine(" You'll also be riding a motorcycle, pretty cool");
            }
            else if (favColor == colorIndigo)
            {
                Console.WriteLine("You'll also have a Hummer Limo. Aye I see you flexing, pretty slick.");
            }
            else if (favColor == colorViolit)
            {
                Console.WriteLine("You'll also be riding in a Audi R8. You better drive safe!");
            }
            else
            {
                Console.WriteLine(" hmm... i don't see any types of transportation in your future. Its ok though. Your legs will work just fine!");
            }




        }
    }
}