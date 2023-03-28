namespace anononymous
{
    delegate void mathOperations(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            mathOperations d1 = delegate(int a,int b) { Console.WriteLine(a + b); };     //T
            mathOperations d2 = sub;
            mathOperations d3 = mul;
            mathOperations d4 = div;
            mathOperations d5 = d1 + d2 + d3;
            //d1 += sub;
            //d1.Invoke(2, 3);
            //d1 += d1.Invoke;
            d5.DynamicInvoke(5, 6);

            //d5.Invoke(2, 3);
            //d5 -= d1;
            // d5 += d4;

            //d5.Invoke(5, 1);

        }

        static void add(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        static void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }

}