using System.Globalization;

namespace RotateMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = Convert.ToInt32(Console.ReadLine());
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, cols];
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0;j<cols;j++)
                {
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());  
                }
            }
            List<int> MyList = new List<int>();
            for (int j = 0; j<cols; j++)
            {
                for (int i = rows-1; i >=0; i--)
                {
                    MyList.Add(matrix[i, j]);
                }
            }

            foreach (int i in MyList)
            {
                Console.Write(i+" ");
            }


        }
    }
}