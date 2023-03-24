namespace practice_prob
{
    internal class Program
    {
        //Write a C# Sharp program to exchange the first and last characters in a given string and return the new string
        /*static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char first = str[0];
            char last = str[str.Length - 1];
            string res = "";
            res += last;
            for(int i=1; i < str.Length-1; i++) 
            {
                res += str[i];
            }
            res += first;
            Console.Write(res);
                
        }*/
        //Write a C# Sharp program to create a new string with the last char added at the front and back of a given string of length 1 or more.
        /*   static void Main(string[] args)
           {
               string str = Console.ReadLine();
               char last = str[str.Length - 1];
               string res = "";
               res += last;
               for (int i = 0; i < str.Length; i++)
               {
                   res += str[i];
               }
               res += last;
               Console.Write(res);
           }*/

        //Write a C# Sharp program to check if a string 'ok' appears in a given string. If it appears return a string without 'ok' otherwise return the original string.
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string res = ""; 
            while(str.Contains("ok"))
            {
                res = "";
                for (int i = 0; i < str.Length; i++)
                {
                    if ((str[i] == 'o' && str[i + 1] == 'k')|| (i!=0 && str[i] == 'k' && str[i-1]=='o'))
                    {
                        continue;
                    }
                    else
                    {
                        res += str[i];
                    }
                }//ashookk
                if (!res.Contains("ok"))
                {
                    break;
                }
                else
                {
                    str = res;
                }
            }
            Console.Write(res);
        }
    }
}