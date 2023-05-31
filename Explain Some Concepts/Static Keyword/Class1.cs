
namespace Static_Keyword
{
    internal class Class1
    {
        int x; //non-static.



        //Counter is a class attribute, not object attribute.
        //called by the name of the class.
        //shared among all objects from the class.
        //allocated in Heap(initialized by zero) before the first usage of the class.
        static int Counter;

        //if u want to initialize a static attribute only once على مستوى الكلاس, do it inside the static constructor.
        static double pi;





        //static ctor cannot be preceded with access modifire(public, private,...).
        //must be parameterless.
        /*will called automaticlly and once مرة واحدة فقط  before creating any object, or calling any static method. 
          لو استخدمت الكلاس بأي شكل سواء عملت أوبجكت أو استخدمت ستاتيك فانكشن فالستاتيك كونستراكتور هيتنفذ فوراً قبلهم  */

        /*So in general we use static ctor to:
              1- write inside it a code u want to exute only one time over the whole programe, 
                 for example: when programe starts connect to the database and stay connected, do not reconnect it. 
              2- initialize static attributes. */
        static Class1()
        {
            Console.WriteLine("Static Ctor");
            pi = 3.14;
        }




        //default ctor
        public Class1()
        {
            Console.WriteLine("Default Ctor");
            Counter++;
        }




        //static method: it is a calss behavior(cannot be accesed with object).
        //deals only with a static members. 
        //does not have access to "this" keyword, because "this" is a reference to the object that call the method, and static method cannot be called with objects.
        public static void CounterZeroed()
        {
            Counter = 0;

            //x = 0; //error: an object reference is required for non-static fields.
        }
    }
}
