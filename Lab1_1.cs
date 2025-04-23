namespace Lab1_2
{
    internal class Lab1_1
    {
        static void Main(string[] args)
        {
            Random random = new Random();                    //Random
            int x = 0; int y = 99; double win = 0;
            int Ans = random.Next(x, y);
            int Num = random.Next(x, y+1);
            int Total = 100000;

            for (int i = 1; i <= Total; i++)
            {
                while(x<y)
                {
                    if (Ans != Num)
                    {
                        if (Num >= x && Num <= y)
                        {
                            if (Num < Ans)
                            {
                                x = Num + 1;
                            }
                            else
                            {
                                y = Num - 1;
                            }
                            if (y - x < 1)
                            {
                                x = 0; y = 99;
                                Ans = random.Next(x, y);
                                break;
                            }
                        }
                    }
                    else
                    {
                        win++;
                        x = 0; y = 99;
                        Ans = random.Next(x, y);
                        break;
                    }
                    Num = random.Next(x, y + 1);
                }
            }
            Console.WriteLine("Random : {0}",win/Total);

//--------------------------------------------------------------------------------//
            int Num1 = random.Next(x, y+1);double win1 = 0; //Binary Search
            for (int i = 1; i <= Total; i++)
            {
                while (x < y)
                {
                    Num1 = (x + y) / 2;               
                    //Console.WriteLine("Ans:{0},Num1:{1},i:{2},x:{3},y:{4}",Ans,Num1,i,x,y);
                    if (Ans != Num1)
                    {
                        if (Num1 >= x && Num1 <= y)
                        {
                            if (Num1 < Ans)
                            {
                                x = Num1 + 1;
                            }
                            else
                            {
                                y = Num1 - 1;
                            }
                            if (y - x < 1)
                            {
                                x = 0; y = 99;
                                Ans = random.Next(x, y);
                                break;
                            }
                        }
                    }
                    else
                    {
                        win1++;
                        x = 0; y = 99;
                        Ans = random.Next(x, y);
                        break;
                    }
                    Num = random.Next(x, y + 1);
                }
            }
            Console.WriteLine("Binary Search : {0}", win1 / Total);

        }
    }
}
