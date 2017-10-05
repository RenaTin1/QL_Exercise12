using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Serena Tindle- Exercise 12 (counting down)
            //variables and while loop
            string UserOption;
            bool ContinueProgram = true;
            while (ContinueProgram == true)
            {
                for (int i = 10-1; i >=0; i--)  //for loop until i equals 0
                {
                    Console.Write(i);
                }

                Console.WriteLine(); //skip to next line
                Console.WriteLine("Would you like to continue? (y/n)"); //Ask user if they want to continue
                UserOption = Console.ReadLine();
                if (UserOption == "N" || UserOption == "No" || UserOption == "no")
                    ContinueProgram = false;//exit program
            }



        }
    }
}
