
namespace Duration
{
    class Duration
    {
        int Hours, Minutes, Seconds;

        //default Ctor//
        public Duration()
        {
                
        }
        //parametized Ctor takes three parameters//
        public Duration(int h, int m, int s)
        {
            Hours = h;  
            Minutes = m; 
            Seconds = s;    
        }
        //parametized Ctor takes one parameter//
        public Duration(int totalSec)
        {
            Hours = totalSec / 3600;
            Minutes = (totalSec % 3600) / 60; 
            Seconds = totalSec % 60; 
        }

     /*-----------------------------------------------*/

        //overloading ToString() method//
        public new void ToString()
        {
            Console.WriteLine($"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}");
        }

     /*-----------------------------------------------*/

        //operator + add two objects//
        public static Duration operator +(Duration d1, Duration d2)
        {
            //Duration d3 = new Duration();    
            //d3.Hours = d1.Hours + d1.Hours; 
            //d3.Minutes = d1.Minutes + d1.Minutes;   
            //d3.Seconds = d1.Seconds + d1.Seconds;   
            //return d3;

            //u can shorten the previous code, and add null propagation operator, as follow:
            return new Duration(d1?.Hours ?? 0 + d2?.Hours ?? 0, d1?.Minutes?? 0 + d2?.Minutes ?? 0, d1?.Seconds ?? 0 + d2?.Seconds ?? 0);
        }
        //operator + add object to integer//
        public static Duration operator +(Duration d1, int d2)
        {
            Duration d3 = new Duration(d2);
            return new Duration(d1?.Hours + d3?.Hours ?? 0, d1?.Minutes + d3?.Minutes ?? 0, d1?.Seconds + d3?.Seconds ?? 0); //null propagation operator
        }
        //operator + add integer to object//
        public static Duration operator +(int d1, Duration d2)
        {
            Duration d3 = new Duration(d1);
            return new Duration(d2?.Hours + d3?.Hours ?? 0, d2?.Minutes + d3?.Minutes ?? 0, d2?.Seconds + d3?.Seconds ?? 0); //null propagation operator
        }

     /*-----------------------------------------------*/

        //Increament and Decrement Operators (++, --)//
        public static Duration operator ++(Duration d1)
        {
            int totalSec = (d1?.Hours * 60 * 60 ?? 0) + (d1?.Minutes * 60 ?? 0) + d1?.Seconds ?? 0; //convert ( Hours:Minutes:seconds ) to seconds only. And use null propagation operator in case the object parameters was null(set his all data -Hours,Minuts,Seconds- with zeros)

            if(totalSec != 0) //means that d1 was not null, because if it is null then totalSec will equal 0
                totalSec += 60;

            Duration d2 = new(totalSec);
            return d2; 
        }
        public static Duration operator --(Duration d1)
        {
            int totalSec = (d1?.Hours * 60 * 60 ?? 0) + (d1?.Minutes * 60 ?? 0) + d1?.Seconds ?? 0; //convert (Hours:Minutes:seconds) to seconds only. And use null propagation operator in case the object parameter was null.(set his all data -Hours,Minuts,Seconds- with zeros)

            if (totalSec != 0)
                totalSec -= 60;

            Duration d2 = new(totalSec);
            return d2;
        }

     /*-----------------------------------------------*/


        //Logical Operators (<, > <=, >=)
        public static bool operator >(Duration d1, Duration d2)
        {
            if(d1.Hours > d2.Hours)
                return true;
            if(d1.Hours == d2.Hours)
            {
                if(d1.Minutes > d2.Minutes) 
                    return true;
            }
            if(d1.Hours == d2.Hours && d1.Minutes == d2.Minutes)
            {
                if (d1.Seconds > d2.Seconds)
                    return true;
            }

            return false;   
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            if (d1.Hours < d2.Hours)
                return true;
            if (d1.Hours == d2.Hours)
            {
                if (d1.Minutes < d2.Minutes)
                    return true;
            }
            if (d1.Hours == d2.Hours && d1.Minutes == d2.Minutes)
            {
                if (d1.Seconds < d2.Seconds)
                    return true;
            }

            return false;
        }
        public static bool operator <=(Duration d1, Duration d2)
        {
            if (d1.Hours <= d2.Hours && d1.Minutes <= d2.Minutes && d1.Seconds <= d2.Seconds)
                return true;

            return false;
        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            if (d1.Hours >= d2.Hours && d1.Minutes >= d2.Minutes && d1.Seconds >= d2.Seconds)
                return true;

            return false;
        }

     /*-----------------------------------------------*/

        //explicit castin with objects --> as: string str = (int)x;//
        public static explicit operator DateTime(Duration d) 
        {
            DateTime dt = DateTime.Now;
            return dt;
        }

    }
}
