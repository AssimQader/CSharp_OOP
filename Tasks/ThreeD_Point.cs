namespace _3D_Point
{
    internal class ThreeD_Point
    {
         double X;
         double Y;
         double Z;


        public ThreeD_Point(double n1, double n2, double n3)
        {
            X = n1;
            Y = n2;
            Z = n3;
        }


        public double GetX()
        {
            return X;
        }
        public void SetX(double value)
        {
            X = value;
        }

        public double GetY()
        {
            return Y;
        }
        public void SetY(double value)
        {
            Y = value;
        }

        public double GetZ()
        {
            return Z;
        }
        public void SetZ(double value)
        {
            Z = value;
        }




        //overeide ToString() method
        public new string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }



        // Operator overloading for == and !=
        public static bool operator ==(ThreeD_Point o1, ThreeD_Point o2)
        {
            return (o1?.X == o2?.X) && (o1?.Y == o2?.Y) && (o1?.Z == o2?.Z);
        }
        public static bool operator !=(ThreeD_Point o1, ThreeD_Point o2)
        {
            return (o1?.X != o2?.X) || (o1?.Y != o2?.Y) || (o1?.Z != o2?.Z);
        }



        //override equals function
        public new bool Equals(object obj)
        {
            //cast the "obj" from datatype(object) to ThreeD_Point datatype, then store the obj in object from the same type of casted.
            ThreeD_Point casted_obj = (ThreeD_Point)obj;


            return X == casted_obj.X && Y == casted_obj.Y && Z == casted_obj.Z;
            //the X of the object that called Equals() = X of the object u pass as a parameter. and so on in Y,Z
        }
    }
}