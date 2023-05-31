namespace _3D_Point
{
    internal class Program
    {
        static void Main()
        {
            ThreeD_Point O1 = new(1, 2, 3);
            ThreeD_Point O2 = new(1, 2, 3);


            Console.WriteLine(O1.ToString());

            Console.WriteLine(O1 == O2);
            Console.WriteLine(O1 != O2);

            Console.WriteLine(O1.Equals(O2)); //before overriding it, it return false because Equals() method compare the addresses not the values, and the address of O1 is not the same of O2, so it returns false.
            //After override it it compars the values. 
        }
    }
}