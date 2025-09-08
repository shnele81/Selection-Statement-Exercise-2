namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("That's great! Math is great for solving problems.");
                    break;
                case "science":
                    Console.WriteLine("That's great! Science is great for learning about how the world works.");
                    break;
                case "history":
                    Console.WriteLine("That's great! History helps us understand where we came from.");
                    break;
                case "english":
                    Console.WriteLine("That's great! English teaches us how to read and write.");
                    break;
                case "pe":
                    Console.WriteLine("That's great! Exercise and physical health is important.");
                    break;
                default:
                    Console.WriteLine("That's an interesting choice. What is your favorite part about that subject?");
                    break;
                
            }
        }
    }
}