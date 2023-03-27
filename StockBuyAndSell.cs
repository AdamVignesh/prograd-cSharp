using System.ComponentModel.Design;

namespace stockBuyAndSell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfDays = Convert.ToInt32(Console.ReadLine());    
            int[] Stockprices = new int[numOfDays];

            for(int iter=0;iter<numOfDays;iter++)
            {
                Stockprices[iter]= Convert.ToInt32(Console.ReadLine()); 

            }
            Console.WriteLine(ans(Stockprices));
           
        }

        public static int ans(int[] prices)
        {
            int profit = 0;
            for(int i=1;i<prices.Length;i++)
            {
                if (prices[i] > prices[i-1])
                {
                    profit += (prices[i] - prices[i - 1]);
                }
            }
            return profit;
        }
    }
}