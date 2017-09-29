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

            Console.WriteLine("Simply Amazing, but I'm a little curious... \nIn number form, what's your birthday month?");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Aye Turn Up! What's your favorite ROYGBIV color? \nIf you don't know the ROYGBIV colors just enter (help)");
            string favColor = Console.ReadLine().ToLower();
            string userHelp = "help";
            Console.WriteLine("\n");
            if (favColor == userHelp)
            {
                Console.WriteLine("Aye that's fine. ROYGBIV is the following colors. \nRed \nOrange \nYellow \nGreen \nBlue \nIndigo \nViolit \nAlright so now which one of these colors is your favorite one?");
                favColor = Console.ReadLine();
            }
            Console.WriteLine("\n");

            Console.WriteLine("Interesting indeed! How many siblings do you have?");
            int siblingNum = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPerfect, I believe I have enough information to declare your fortune!\nAre you ready? Yes, or No");
            string readyUp = Console.ReadLine().ToLower();
            string agree = "yes";
            Console.WriteLine();
            if (readyUp == agree)
            {
                Console.WriteLine("\nExpectooo Patronum!!");
            }
            else
            {
                Console.WriteLine("\nI don't get paid enough to not give out fortunes");
            }




        }
    }
}
