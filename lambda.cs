namespace LambdaExpression
{
   // delegate void add(int a, int b);
    delegate void welcome(string msg);
    internal class Program
    {
        static void Main(string[] args)
        {
            //add d1 = (num1,num2) =>Console.WriteLine(num1 + num2);
            welcome d2 = (msg) => Console.WriteLine(msg);           //Lambda Function using delegates
            welcome d3 = delegate (string msg) { Console.WriteLine(msg); }; //Anonymous Function

            //Console.WriteLine(d1(2,3));
            // d1(2, 3);
            var ans = (string msg) => Console.Write(msg);         //Lambda Function without using delegate
            ans("This is from lambda function without using delegate");
            var sum = (int num1, int num2) => num1 + num2;
            sum += (int num1, int num2) => num1 - num2;
            Console.WriteLine(sum(6,5));
            d2("welcome to presidio from d2");
            d3("welcome to presidio from d3");
        }
    }
}