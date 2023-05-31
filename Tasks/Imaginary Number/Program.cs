using System.Reflection.Metadata.Ecma335;

namespace ImaginaryNumber
{
    class Program
    {
        class RealImgNumber
        {
            int Real;
            int Img;

            public void SetReal()
            {
                this.Real = Convert.ToInt32(Console.ReadLine());
            }

            public void SetImg()
            {
                this.Img = Convert.ToInt32(Console.ReadLine());
            }

            public void ShowData()
            {
                char sign = '+';

                //Real == 0//
                if (Real == 0 && Img < 0)  
                {
                    if (Img == -1)
                        Console.WriteLine($"-i");
                    else
                        Console.WriteLine($"{Img}i");

                    return;
                }
                if (Real == 0 && Img > 0)  
                {
                    Console.WriteLine($"{Img}i");
                    return;
                }
                if (Real == 0 && Img == 0)
                {
                    Console.WriteLine("0");
                    return;
                }


                //Real < 0//
                if (Real < 0 && Img < 0)
                {
                    if (Img == -1)
                        Console.WriteLine($"{Real}-i");
                    else //any negative number except -1
                        Console.WriteLine($"{Real}{Img}i");
                    return;
                }
                if (Real < 0 && Img == 0)
                {
                    Console.WriteLine(Real);
                    return;
                }


                //Real > 0
                if (Real > 0 && Img == 1)  
                {
                    Console.WriteLine($"{Real}{sign}i");
                    return;
                }
                if (Real > 0 && Img == -1)
                {
                    sign = '-';
                    Console.WriteLine($"{Real}{sign}i");
                    return;
                }
                if (Real > 0 && Img < 0)
                {
                    sign = '-';
                    Img = -(Img);
                }
                if (Real > 0 && Img == 0)
                {
                    Console.WriteLine(Real);
                    return;
                }



                Console.WriteLine($"{Real}{sign}{Img}i");
            }
        }

        static void Main()
        {
            RealImgNumber ri = new RealImgNumber();

            ri.SetReal();   
            ri.SetImg();

            ri.ShowData();    
        }
    }
}