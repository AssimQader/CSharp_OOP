namespace NIC
{
    class Program
    {
        static void Main()
        {
            NIC_Instance ni_1 = NIC_Instance.getNicSingeltone();
            Console.WriteLine(ni_1.GetHashCode()); //output: 27252167
            ni_1.showData();

            NIC_Instance ni_2 = NIC_Instance.getNicSingeltone();
            Console.WriteLine(ni_2.GetHashCode()); //output: 27252167
            ni_2.showData();
        }
    }
}