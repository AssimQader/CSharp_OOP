namespace MathClass
{
    class Program
    {
        static void Main()
        {
            int x = 10, y =0;

            Console.WriteLine(MathUtility.Add(x, y));
            Console.WriteLine(MathUtility.Multi(x, y));
            Console.WriteLine(MathUtility.Substract(x, y));

            int result = MathUtility.Divide(x, y);
            Console.WriteLine(result == -1 ? "Divid by zero is not right" : result);
        }
    }
}