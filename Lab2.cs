namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter number of citizens:");
            int N = int.Parse(Console.ReadLine());
            int[] contacts = new int[N];
            Console.Write("Id :         ");
            for (int i = 0; i < N; i++)
            {
                contacts[i] = i;
                Console.Write("{0,  3}", contacts[i]);
            }

            Console.WriteLine();

            Random rng = new Random();
            Console.Write("Contactee :  ");
            for (int i = N - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                int temp = contacts[i];
                contacts[i] = contacts[j];
                contacts[j] = temp;
            }
 
            for (int i = 0; i < N; i++)
            {
                Console.Write("{0,  3}", contacts[i]);
            }
            Console.WriteLine("\n------------------------");

            List<int> chain = new List<int>();
            HashSet<int> visited = new HashSet<int>();
            Console.WriteLine("\nEnter id of infected citizen:");
            int current = int.Parse(Console.ReadLine());
            while (!visited.Contains(current))
            {
                chain.Add(current);
                visited.Add(current);
                current = contacts[current];
            }
            Console.WriteLine("These citizens are to be self-isolated in the following 14 days:");
            foreach (int id in chain)
            {
                Console.Write(id + " ");
            }
            Console.WriteLine();
        }
    }
}
