namespace Random_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Geef een getal in: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Geef een 2de getal in: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int randomNumber = random.Next(firstNumber, secondNumber+1);

            Console.WriteLine("Random number: " + randomNumber);
        }
    }
}