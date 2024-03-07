namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your first name ?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hey there {userName}, what is your favorite song ?");
            var song = Console.ReadLine();

            Console.WriteLine($"{song} is a very cool song. What is your favorite food ?");
            var food = Console.ReadLine();

            Console.WriteLine($"Delicious ! Now what is your favorite hobby ?");
            var hobby = Console.ReadLine();

            Console.WriteLine($"That's great {userName} ! Here is your account info");
            Console.WriteLine("------------------------------------");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Song: {song}");
            Console.WriteLine($"Favorite Food: {food}");
            Console.WriteLine($"Favorite Hobby: {hobby}");




        }
    }
}
