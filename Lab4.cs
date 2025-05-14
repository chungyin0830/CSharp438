namespace Lab4
{
    public interface Player
    {
        int Next(int x, int y);
        public virtual string ToString()
        {
            return "Player";
        }
    }
    public class Game
    {
        public Player player;
        int min; 
        int max;
        int secretNumber;
        public bool Win;
        
        public Game(Player Player, int x = 0, int y = 99)
        {
            player = Player;
            min = x;
            max = y;
            Random rand = new Random();
            secretNumber = rand.Next(min, max + 1);
        }
        public void Run()
        {
            int guess = player.Next(min, max);

            while (guess != secretNumber)
            {
                if (guess >= min && guess <= max)
                {
                    if (guess < secretNumber)
                        min = guess + 1;
                    else
                        max = guess - 1;

                    if (max - min < 1)
                    {
                        Console.WriteLine("GG");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Out of Range, Try Again?");
                }

                guess = player.Next(min, max);
            }

            Console.WriteLine("Bingo!");
        } 
    }
    public class HumanPlayer : Player
    {
        public override string ToString()
        {
            return "Human Player";
        }
        public int Next(int lowerBound, int upperBound)
        {
            Console.WriteLine("({0},{1})", lowerBound, upperBound);
            int guess;
            while (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.WriteLine("Invalid input. Please enter a number:");
            }
            return guess;
        }
    }
    public class NaiveAI : Player
    {
        private readonly Random _random;
        public override string ToString()
        {
            return "Random AI";
        }
        public NaiveAI()
        {
            _random = new Random();
        }

        public int Next(int lowerBound, int upperBound)
        {
            int guess = _random.Next(lowerBound, upperBound + 1);
            Console.WriteLine("guesses: {0}", guess);
            return guess;
        }

    }
    public class BinarySearchAI: Player
    {
        private int lastGuess = 0;

        public override string ToString()
        {
            return "Binary Search AI";
        }
        public int Next(int lowerBound, int upperBound)
        {
            lastGuess = (lowerBound + upperBound) / 2;
            Console.WriteLine("guesses: {0}", lastGuess);
            return lastGuess;
        }
    }
    public class SuperAI : Player
    {
        private int lastGuess = 0;
        public override string ToString()
        {
            return "Super AI";
        }
        public int Next(int lowerBound, int upperBound)
        {
            lastGuess = ((lowerBound-1) + 1);
            Console.WriteLine("guesses: {0}", lastGuess);
            return lastGuess;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Player player = new HumanPlayer();
            //Player player = new NaiveAI();
            //Player player = new BinarySearchAI();
            Player player = new SuperAI();
            Console.WriteLine(player.ToString());
            Game game = new Game(player);
            game.Run();
        }
    }
}
