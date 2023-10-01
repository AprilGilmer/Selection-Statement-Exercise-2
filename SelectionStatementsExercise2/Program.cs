namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What are your favorite subjects out of these choices: Math, Science, English, PE, or History?");
            string schoolSubject = Console.ReadLine().ToLower();
            switch (schoolSubject)
            {
                case "math":
                    Console.WriteLine("Yay, You like Math!");
                    break;
                case "science":
                    Console.WriteLine("Awesome, I love science too!");
                    break;
                case "english":
                    Console.WriteLine("Really english...I guess I'll let it slide.");
                    break;
                case "pe":
                    Console.WriteLine("PE...Is that really a subject?"); 
                    break;
                case "history":
                    Console.WriteLine("Cool. You must like hanging out with ghost and stuff.");
                    break;
                default:
                    Console.WriteLine("Hmmm..Looks like you didn't read the directions correctly. Please read the directions thoroughly this time around.");
                    break;
            }
        }
    }
}