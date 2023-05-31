namespace Duration
{
    class Program
    {
        static void Main()
        {
            Duration d1 = new Duration(666);
            d1.ToString();

         //----------------------------------------------------//

            Duration d2 = new Duration(1, 3, 20);
            Duration d3 = new Duration(1, 59, 59);
            Duration d4 = d2 + d3;
            d4.ToString();

         //----------------------------------------------------//

            Duration d5 = default;
            d4 = ++d5; //I made d5 = null(default), and because I handled it using null propagation in the metod, so it returns zeros, no exception thrown.
            d4.ToString(); //Hours: 0, Minutes: 0, Seconds: 0

            d4 = ++d3;
            d4.ToString();
            d4 = ++d3;
            d4.ToString(); 
            d3.ToString();  // d3 changed


            d4 = --d5;
            d4.ToString();

         //----------------------------------------------------//

            int seconds = 7800;
            d4 = d3 + seconds;
            d4.ToString();

         //----------------------------------------------------//

            Duration d6 = new Duration(2,10,30);
            Duration d7 = new Duration(2, 10, 31);

            Console.WriteLine(d7 > d6 ? "Yes" : "No");  //ternary operator
            Console.WriteLine(d6 <= d5 ? "Yes" : "No");

         //----------------------------------------------------//

            Duration d8 = new(1, 45, 10);
            DateTime dt = (DateTime)d8;
            Console.WriteLine(dt);

         //----------------------------------------------------//
        }
    }
}