namespace Array
{
    internal class Program
    {
        static int MaxDistance(int[] arr1, int size)
        {
            int max = 0 , temp = 0;
            for (int i = 0; i <= (size / 2); i++) //start iterating from index 0
            {
                for (int j = size - 1; j > (size / 2); j--)  //start iterating from the last index.
                {
                    if (arr1[j] == arr1[i])
                    {
                        temp = (j - i) - 1;
                    }

                    if (temp > max)
                        max = temp;
                }
            }

            return max;
        }
        static void Main()
        {
            int size = Convert.ToInt32(Console.ReadLine()); //get ths size of the arry from user.

            int[] arr = new int [size];
            for (int i = 0; i < size; i++) //get the elements from user.
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(MaxDistance(arr, size));
        }
    }
}