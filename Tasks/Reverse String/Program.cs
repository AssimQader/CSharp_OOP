namespace ReversString
{
    class Program
    {
        static string ReverseString(string s)
        {
            string[] str2 = s.Split(" ");  //split() returns array of string.

            Array.Reverse(str2); //Reverse() method in Array class reversing the order of the array(words).

            string str3 = string.Join(" ", str2); //join() method in string class turns the array of strings to one string.

            return str3;
        }
        static void Main()
        {
            string str = Console.ReadLine();

            Console.WriteLine(ReverseString(str));
        }
    }
}