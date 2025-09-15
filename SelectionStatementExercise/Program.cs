using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            //first exercise
            int favNumber = 11;
            Console.WriteLine("guess my favorite number");
            int userInput = int.Parse(Console.ReadLine());
            
            
            if (userInput < favNumber)
            {
                Console.WriteLine("too low");
            }
            
            else if (userInput > favNumber)
            {
                Console.WriteLine("too high");
                
            }
            else
            {
                Console.WriteLine("you guessed it!");
            }
            //second exercise

            Console.WriteLine("What is your favorite school subject");
            string schoolSubject = Console.ReadLine();
            
            switch (schoolSubject)
            {
                case "Math":
                    Console.WriteLine("Math is such a cool subject i love solving problems");
                    break;
                case "Biology":
                    Console.WriteLine("Biology is a cool subject because you get to learn about so many cool things'");
                    break;
                case "History":
                    Console.WriteLine("I love how we keep th history of our world");
                    break;
                case "English":
                    Console.WriteLine("English is a great subject to expand your knowledge base");
                    break;
                case "Chemistry":
                    Console.WriteLine("i like Chemistry because you get to do experiments");
                    break;
                default:
                    Console.WriteLine("that's a great choice What do you like about it");
                    break;
            }
            











        }
        
    }
}
