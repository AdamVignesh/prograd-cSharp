using System.Reflection.Metadata.Ecma335;

namespace builtInDelegates
{

    delegate void Display();

    internal class Program
    {
        static void Main(string[] args)
        {
            //Display d = helloWorld;
            //d();

            Action<string> act = (msg) => Console.WriteLine(msg);      //Action delegate
            act("from action delegate");

            Func<int, int, int> fun = (a, b) => a + b;      //FUNC delegate
            Console.WriteLine(fun(2, 3));

            Predicate<int> p = (a) => {return a > 5; };     //Predicate delegate
            Console.WriteLine(p(7));
        }

        static void helloWorld() 
        {
            Console.WriteLine("hello");
        }
    }
}