using System.Diagnostics;

namespace Number_Of_Ones_NumericWay
{
    class Program
    {
        static int Count_1s()
        {
            int counter = 0;
            for (int i = 0; i <= 99999999; i++)
            {
                int num = i;
                while (num != 0)
                {
                    if (num % 10 == 1) //to cut the big numbers until it equals 0. (123 --> 12.3 --> 1.2 --> 1 --> 0)
                        counter++;

                    num /= 10;
                }
            }
            return counter;
        }

        static void Main(string[] args)
        {
            //NUMERIC way:  O(n2)

            var timer = new Stopwatch();
            timer.Start();

            Console.WriteLine(Count_1s());

            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds / 1000);

        }
    }
}


