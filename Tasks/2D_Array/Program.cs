using System.Transactions;

namespace _2D_Array
{
    class Program
    {
        static void setUserValues(int[,] td ,int r, int c)
        {
            Console.WriteLine("Enter the values of the matrix:");

            for (int i = 0; i < r; i++)
            {
                Console.WriteLine("Row number #" + (i + 1));
                for (int j = 0; j < c; j++)
                {
                    td[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        static int[] getSumOfRows(int[,] td, int r, int c)
        {
            int[] arrOfSums = new int[r];

            for (int i = 0; i < r; i++)
            {
                int sum = 0;

                for (int j = 0; j < c; j++)
                {
                    sum += td[i, j];
                }

                arrOfSums[i] = sum;
            }

            return arrOfSums;
        }

        static int[] getAvgOfCols(int[,] td, int r, int c)
        {
            int[] arrOfAvgs = new int[c];

            for (int i = 0; i < c; i++)
            {
                int sum = 0;

                for (int j = 0; j < r; j++)
                {
                    sum += td[j, i];
                }

                arrOfAvgs[i] = sum/r;
            }

            return arrOfAvgs;
        }

        static void Main()
        {
            Console.WriteLine("Enter the size of 2D array: rows then cols");
            int rows = Convert.ToInt32(Console.ReadLine()); 
            int cols = Convert.ToInt32(Console.ReadLine()); 

            //creat the 2d array.
            int[,] twoD = new int[rows, cols]; 

            //set the values:
            setUserValues(twoD,rows, cols);

            //get sum of each row:
            int[] sumOfRows = getSumOfRows(twoD, rows, cols);
            for (int i = 0; i < sumOfRows.Length; i++)
            {
                Console.WriteLine("The sum of row #" + (i + 1) + " = " + sumOfRows[i]);
            }

            Console.WriteLine("------------------------------------------------");

            //get average of each col:
            int[] avgOfCols = getAvgOfCols(twoD, rows, cols);
            for (int i = 0; i < avgOfCols.Length; i++)
            {
                Console.WriteLine("The Avg of col #" + (i + 1) + " = " + avgOfCols[i]);
            }
        }
    }
}