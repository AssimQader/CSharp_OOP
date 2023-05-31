namespace Static_Keyword
{
    internal class Program
    {
        static void Main()
        {
            Class1.CounterZeroed(); //static ctor called, but default ctor not.
            /*this line causes the next بالترتييييب:
            1. printout "Static Ctor" in console
            2. initialize pi = 3.14 
            3. excute CounterZeroed() method */
        }
    }
}