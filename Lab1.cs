namespace Lab1
{
    internal class Lab1
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int x = 0;int y = 99;
            int Ans = random.Next(x, y);
            Console.WriteLine("({0},{1})", x, y);
            int Num = int.Parse(Console.ReadLine());

            while (Ans != Num)
            {
                if (Num >= x && Num <= y)
                {
                    if (Num < Ans)
                    {
                        x = Num+1;
                    }
                    else
                    {
                        y = Num-1;
                    }
                    if (y-x < 1)
                    {
                        break;
                    }  
                }
                else 
                {
                    Console.WriteLine("Out of Range, Try Again?");
                }
                Console.WriteLine("({0},{1})", x, y);
                Num = int.Parse(Console.ReadLine());
            }
            if (Ans == Num)
            {
                Console.WriteLine("Bingo!");
            }
            else 
            { 
                Console.WriteLine("GG"); 
            } 
        }
    }
}
