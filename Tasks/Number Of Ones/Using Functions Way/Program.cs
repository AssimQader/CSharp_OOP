using System.Diagnostics;

namespace Number_Of_Ones_FunctionsWay
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Number of 1s using Math's functions
            var timer = new Stopwatch();
            timer.Start();


            int num = Convert.ToInt32(Console.ReadLine());


            var numOfDigits = Math.Log10(num);  //gives the number of digits of any number-1. //output: 7.99 

            var counter = Convert.ToInt32((numOfDigits) * Math.Pow(10, Math.Floor(numOfDigits)));
            Console.WriteLine(counter);


            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds / 1000);



            /*  Console.WriteLine(Convert.ToInt32(numOfDigits)); //output: 8   قربت الرقم العشري لرقم صحيح 
                Math.Pow( 10, Math.Floor(numOfDigits)); //pow(10,7) 

                the algorithm is: the number of 1s in any sequence from 1 to n(as n is 9 or 99 or 999 or 9999 or 999999 , ...etc)
                is counted by the mathmatical: [digits * 10^(digits-1) ] because there is a pattern:
                
                if n consist of one digit (9 for ex) --> the number of 1s from 1 to this n = 1
                if n consist of two digits (99 for ex) --> the number of 1s from 1 to this n = 20
                if n consist of three digits (999 for ex) --> the number of 1s from 1 to this n = 300 

                so as u note the number of 1s = [ number of digits * 10^(number of digits-1) ]. 
             */
            #endregion
        }
    }
}