
namespace Sinelton_Explaination
{
    internal class Computer_NIC
    {
        static string Manufacture;
        static string MacAddress;
        static string Type;


        //1- private object(default) ctor: this ctor is for الاستخدام الداخلي فقط, means that I can create objects only inside the class.
        private Computer_NIC() { }



        //2.1- private ctatic reference to object
        static Computer_NIC cn;

        /*2.2- private static ctor: put the initalization of the object here, beacuse as u know waht is inside static ctor is excuted only once over the program liftime.
            and that is waht I want.. creating(initalizing) object for only one time. */
        static Computer_NIC()
        {
            cn = new Computer_NIC();
        }



        //3- static method to set the data of ur NIC object(cn), then return it
        public static Computer_NIC GetComputerNIC()
        {
            Manufacture = "DELL";
            MacAddress = "CC-2F-71-C9-52-11";
            Type = "Ethernet";

            return cn;
        }


        //This shape of Singelton implementation is Thread-safe, because of static Ctor. 
     //----------------------------------------------------------------------//


        public void showData()
        {
            Console.WriteLine($"{Manufacture} , {MacAddress} , {Type}");
        }
    }
}
