namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;

        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;

        }
      
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;

        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;

        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }



        static void Main(string[] args)
        {

            var amountOfFruits = Sum(8, 10, 20);
            var numberOfCars = Multiply(4, 6, 11);
            var numberOfStudents = Subtract(100, 35);
            var amountOfMoney = Divide(2000, 5);
            var amountOfShirts = Modulus(20, 3);






            //----------------------exercise 1-------------------------------
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
