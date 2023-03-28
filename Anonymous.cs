namespace Anonymous
{
    delegate void delegateForAdd(int a, int b);
    delegate void delegateForPrint(string msg);
    delegate int delegateForTesting(string pass);
    internal class Program
    {
        static void Main(string[] args)
        {
            delegateForAdd d1 = delegate (int a, int b) { Console.WriteLine(a + b); };
            d1(2, 4);

            delegateForPrint d2 = delegate (string msg){Console.WriteLine(msg);};
            d2("hello from anonymous method");

            delegateForTesting d3 = delegate (string pass)
            {
                if (pass.Equals("adam"))
                    {
                    return 1;
                    }
                return 0;
            };
            Console.WriteLine(d3("adam"));
        }
        static void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        
    }
}