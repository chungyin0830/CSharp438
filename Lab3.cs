namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            Console.WriteLine("\nMatrix after filling with random values: ");
            int total = rows * cols;
            int[] numbers = new int[total];
            for (int i = 0; i < total; i++)
            {
                numbers[i] = i;
            }

            Random rand = new Random();
            int[] array = numbers;
            for (int ii = array.Length - 1; ii > 0; ii--)
            {
                int jj = rand.Next(ii + 1);
                (array[ii], array[jj]) = (array[jj], array[ii]);
            }

            int[,] matrix = new int[rows, cols];
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = numbers[index++];
                    Console.Write("{0, 4}",matrix[i, j].ToString());
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatrix after performing row exchanges based on the first column: ");

            int matrix_rows = matrix.GetLength(0);
            int matrix_cols = matrix.GetLength(1);

            for (int i = 0; i < matrix_rows - 1; i++)
            {
                for (int j = i + 1; j < matrix_rows; j++)
                {
                    if (matrix[i, 0] > matrix[j, 0])
                    {
                        for (int k = 0; k < matrix_cols; k++)
                        {
                            (matrix[i, k], matrix[j, k]) = (matrix[j, k], matrix[i, k]);
                        }
                    }
                }
            }
            int rows2 = matrix.GetLength(0);
            int cols2 = matrix.GetLength(1);
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                    Console.Write("{0, 4}",matrix[i, j].ToString());
                Console.WriteLine();
            }
        }
    }
}
