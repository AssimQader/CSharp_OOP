namespace Sinelton_Explaination
{
    internal class Program
    {
        static void Main()
        {

            Computer_NIC cn1 = new Computer_NIC();
            Computer_NIC cn2 = new Computer_NIC();  
            //ur computer only have one NIC, it is not correct to create more than one NIC(object) to ur machine as in the previous line.
            /*so we need to make the class Computer_NIC can create only one object(NIC) from it... so use "Singeltone" design pattern on this class. 
               1- create a private default ctor: to prevent creating any objects from this class by the user or programmer in Main().
               2- create ur own statitc object(NIC) inside the class itself. static is to make this attribute a class attribute, not object one. Then initialize it inside a stitc ctor.
               3- create a static method that retutn this object.
             */



            //proof that only one object is created:
            Computer_NIC cn1 = Computer_NIC.GetComputerNIC();
            Console.WriteLine(cn1.GetHashCode()); //output: 27252167
            cn1.showData(); //data

            Computer_NIC cn2 = Computer_NIC.GetComputerNIC();
            Console.WriteLine(cn1.GetHashCode()); //output: 27252167
            cn1.showData();  //the same data


          /* As u see: the identity number of cn1 is the same of cn2, this means that there is an only
             one object and two refrences refere to it, not two objects :) */
        }
    }
}