namespace NIC
{
    sealed class NIC_Instance
    {
        static string Manufacture;
        static string MacAddress;
        static string Type;


     //  SINGELTON Design Pattern   //


        //private ctor.
        private NIC_Instance() { }


        /*private static obj from the same class type.
             Assignin it in the same line( = new NIC_Instance ) is the same if u do it in static ctor,
             in IL code file the static ctor will be created by the compiler implicitlyضمنياً, and the ( = new NIC_Instance) statement is put inside it */
        private static NIC_Instance Nic = new NIC_Instance(); 


        //public static method returns the object.
        public static NIC_Instance getNicSingeltone()
        {
            Manufacture = "DELL";
            MacAddress = "00-15-5D-8F-FE-D6";
            Type = "Ethernet";

            return Nic;
        }

        public void showData()
        {
            Console.WriteLine($"{Manufacture} , {MacAddress} , {Type}");
        }
    }
}
