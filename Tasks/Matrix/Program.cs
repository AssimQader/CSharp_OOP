namespace Matrix
{
    class Program
    {
        static void Main()
        {
            int size = Convert.ToInt32(Console.ReadLine());
            while (size % 2 == 0)
            {
                Console.WriteLine("Enter an Odd numbers only!");
                size = Convert.ToInt32(Console.ReadLine());
            }

            int num = size * size;
            int row = 1, col = (size / 2) + 1; //to get the middle column of the matrix.

            for (int i = 1; i <= num; ++i)
            {
                Console.SetCursorPosition(col * 5, row * 5); // *5 to expand the shape of the matrix.
                Console.WriteLine(i);

                if (i % size != 0)
                {
                    row--;
                    col--;

                    if (col == 0)
                        col = size;
                    if (row == 0)
                        row = size;
                }
                else
                {
                    row++;

                    if (row == size + 1)
                        row = 1;
                    if (row == size + 1)
                        row = 1;
                }
            }
        }
        
    }
}