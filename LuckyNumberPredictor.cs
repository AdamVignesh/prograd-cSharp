using System.Runtime.CompilerServices;

namespace LuckyNumberPredictor
{
    internal class Program : SecretFormula
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the date of your birth");
            int date = Convert.ToInt32(Console.ReadLine());
            SecretFormula obj = new SecretFormula();
            obj.predictLuckyNumber(date);

        }
    }
    class SecretFormula
    {
        private List<int> fibo = new List<int>();
        protected internal void predictLuckyNumber(int date)
        {
            int a = 0;
            int b = 1; 
            fibo.Add(a);
            fibo.Add(b);

            while(fibo[fibo.Count-1]<date)
            {
                int temp = a+b;
                a = b;
                b = temp;
                fibo.Add(temp);
            }

            if (fibo[fibo.Count-1] - date > fibo[fibo.Count-2] - date)
            {
                Console.WriteLine($"your lucky number is {fibo[fibo.Count - 2]}");
            }
            else
            {
                Console.WriteLine($"your lucky number is {fibo[fibo.Count - 1]}");
            }
        }
    }
}