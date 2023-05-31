namespace MathClass
{
    //static class: use as utility... cannot create objects from it//
    public static class MathUtility
    {
        public static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Substract(int n1, int n2)
        {
            return n1 - n2;
        }
        public static int Multi(int n1, int n2)
        {
            return n1 * n2;
        }
        public static int Divide(int n1, int n2)
        {
            return n2 == 0 ? -1 : n1 / n2;
        }
    }
}
