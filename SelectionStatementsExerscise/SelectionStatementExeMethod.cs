using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatementsExerscise
{
    internal class SelectionStatementExeMethod
    {

        public static void RandNum()
            //Exercise 1:
        {
            var r = new Random();
            var favNum = r.Next(1, 5);
            Console.WriteLine("Try to guess my favourite number!");
            var userInput = int.Parse(Console.ReadLine());
           

            if (userInput < favNum)
            {
                Console.WriteLine($"{userInput} is too low. Hidden number is {favNum}.");
            }
            else if (userInput > favNum)
            {
                Console.WriteLine($"{userInput} is too high. Hidden number is {favNum}.");
            }
            else
            {
                Console.WriteLine("Good guess!!! You won the game!!!");
                Console.WriteLine($"Hidden number is {favNum}.");
            }
        }
        //Exercise 2:
        public static void FavSubjStr()
        {
            //1. Ask the user for their favourite school sunbject:
            Console.WriteLine("What is your favourite school subject?");
            //2. Store their answer in a variable:
            var UserFavSubj = Console.ReadLine();
            //3. Create 5 different cases for different subjects:
            
            switch (UserFavSubj.ToLower())
            {
                     //case 1
                case "chemistry": 
                    Console.WriteLine("Nice! You like chemistry!");
                    break;
                     //case 2
                case "math": 
                    Console.WriteLine("Great! Knowing math is important!");
                    break;
                      //case 3
                case "literature": 
                    Console.WriteLine("Literature is a great choice!");
                    break;
                      //case 4
                case "pe": 
                    Console.WriteLine("PE is great for your health!");
                    break;
                      //case 4
                case "grammar": 
                    Console.WriteLine("Great! Knowing grammar is important!");            
                    break;

                    default: 
                    Console.WriteLine($"The subject {UserFavSubj} is not included in this program🤷‍♂️");
                    break;
                         
            }

        }

    }
}
