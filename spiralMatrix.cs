using System.Collections.Generic;

namespace spiralMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[m, n]; 

            for(int iter=0;iter<m;iter++)
            {
                for(int jter=0;jter<n;jter++)
                {
                    arr[iter,jter] = Convert.ToInt32(Console.ReadLine()); 
                }
            }
            Boolean [,] visited = new Boolean[m, n];
            int count = 0;
            // List myList<int> = new List<int>();
            int i = 0, j = 0;
            while(count<=m*n)
            {
                while(j<n && !visited[i, j] &&  count <=m*n)
                {
                    
                        count++;
                        
                        visited[i, j] = true;
                        Console.Write(arr[i, j] + " ");
                        j++;
                    
                }
                if (count == m * n)
                {
                    break;
                }
                j--;
                i++;
               
                while(i<m && !visited[i, j] && count <= m * n)
                {
                        count++;
                        
                        visited[i, j] = true;
                        Console.Write(arr[i, j] + " ");
                        i++;
                    
                }
                if (count == m * n)
                {
                    break;
                }
                i--;
                j--;
                
                while (j>=0 && !visited[i, j] && count <= m * n)
                {
                    
                        visited[i, j] = true;
                        count++;
                        Console.Write(arr[i, j] + " ");
                        j--;
                    
                }
                if (count == m * n)
                {
                    break;
                }
                j++;
                i--;
        
                while (i >= 0 && !visited[i, j] && count <= m * n)
                {
                    
                        
                        visited[i, j] = true;
                        count++;
                        Console.Write(arr[i, j] + " ");
                        i--;
                   
                }
                if (count == m * n)
                {
                    break;
                }
                i++;
                j++;
                
            }

            
           
        }
    }
}