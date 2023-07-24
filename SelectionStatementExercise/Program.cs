namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var rdmNumber = r.Next(1, 10);

            Console.WriteLine("Try to guess the random number between 1 and 10! (It will change each time)");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < rdmNumber)
            {
                Console.WriteLine("too low");
            }
            else if (userInput > rdmNumber)
            {
                Console.WriteLine("too high");
            }
            else
            {
                Console.WriteLine("You guessed it!!!");
            }
        }
    }
}
