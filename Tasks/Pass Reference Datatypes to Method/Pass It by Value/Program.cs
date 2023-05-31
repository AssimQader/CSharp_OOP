namespace PassBy_Value_Ref
{
    class Program
    {
        static void PassValue(int[] arr)
        {
            Console.WriteLine("Identity Number of arr before reasign it: " + arr.GetHashCode()); //54267293
            arr[0] = 555;  // This affects the original element[0] in Arr1 in Main().

            arr = new int[5] { 100, 200, 300, 400, 500 }; // This affects only in this PassValue() method.
            Console.WriteLine("Identity Number of arr after reasign it inside PassValue(): " + arr.GetHashCode()); //18643596

            Console.WriteLine("Inside the method, " + arr[0]);
        }

        static void Main(string[] args)
        {
            int[] Arr1 = new int[] { 1, 2, 3 };
            Console.WriteLine("Inside Main() before call the method, " + Arr1[0]); //1

            PassValue(Arr1);
            Console.WriteLine("Identity Number of Arr1 in Main() " + Arr1.GetHashCode()); //54267293
            Console.WriteLine("Inside Main() after call the method, " + Arr1[0]); //555
        }
    }
}
