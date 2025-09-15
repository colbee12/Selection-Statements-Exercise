using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
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
    }
        
    }
}
