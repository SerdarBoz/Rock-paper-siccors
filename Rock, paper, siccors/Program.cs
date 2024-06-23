namespace Rock__paper__siccors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to Rock, Paper, Scissors!");
                Console.Write("Enter your choice (rock, paper, or scissors): ");
                string playerChoice = Console.ReadLine().ToLower();

                if (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
                {
                    Console.WriteLine("Invalid choice. Please enter 'rock', 'paper', or 'scissors'.");
                    continue;
                }

                Random random = new Random();
                int randomNum = random.Next(0, 3);

                string computerChoice;
                if (randomNum == 0)
                    computerChoice = "rock";
                else if (randomNum == 1)
                    computerChoice = "paper";
                else
                    computerChoice = "scissors";

                Console.WriteLine($"Computer chose: {computerChoice}");

                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if (
                    (playerChoice == "rock" && computerChoice == "scissors") ||
                    (playerChoice == "paper" && computerChoice == "rock") ||
                    (playerChoice == "scissors" && computerChoice == "paper")
                )
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("Computer wins!");
                }

                Console.Write("Play again? (yes/no): ");
                string playAgain = Console.ReadLine().ToLower();

                if (playAgain != "yes")
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }
            }
        }
    }
}