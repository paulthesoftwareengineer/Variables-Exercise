namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string name = "Paul Turner";
            int age = 42;
            char letter = 'A';
            bool isDeveloper = true;
            double temperature = 98.6;
            decimal price = 19.99m;

            Console.WriteLine($"My name is {name}. I am {age} years old. I like to earn {letter}s in this program. I am a better developer{isDeveloper} then the temperature is {temperature} and the price of lunch is below {price}. ");
        }
    }
}
