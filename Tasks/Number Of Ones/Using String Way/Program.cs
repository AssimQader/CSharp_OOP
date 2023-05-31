using System.Diagnostics;

namespace Number_of_Ones
{
    class Program
    {
        static void Main()
        {
            //Note: Uncomment the code to understand it//


            // O(n2)  two for loops: 

            //int counter = 0;
            //for (int num = 1; num < 99999999; num++) 
            //{
            //    string numString = num.ToString();
            //    foreach(char c in numString)
            //    {
            //        if (c == '1')
            //            counter++;
            //    }
            //}

            //Console.WriteLine(counter);

            /*---------------------------------------------------------*/

            //Better way: O(n)  one for loop: 


            //string str = "1234193819311831";
            //int countr = 0;
            //countr = countr + str.Split("1").Length - 1;

            ////Split() returns an array of substrings divided from the seperator "1".
            ////the length of this array equals (the number of seperators + 1).
            ////in our case: number of "1" in str = 6, so the length of the array is 7.
            ////So in the previous problem we need to count the number of 1, thats why we subtract 1, which become 6 and then add 6 to the current counter value.

            //Console.WriteLine(countr); //output: 6


            //Now let's apply this way to make the time complexty change from n2 to n:
            int counter = 0;

            var timer = new Stopwatch();
            timer.Start();

            for (int num = 1; num < 99999999; num++)
            {
                string numString = num.ToString();
                counter = counter + numString.Split("1").Length - 1;
            }
            Console.WriteLine(counter);

            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds / 1000); //output: 8 seconds
        }
    }
}



    
