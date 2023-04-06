using System.Security.Claims;

namespace Nico_Cipher
{
    public class Nico_code_finder
    {

        public static string codeFinder(string message, string key)
        {
            string sortedKey = String.Concat(key.OrderBy(c => c));          // sorting the key
            Dictionary<char, List<int>> dict = new Dictionary<char, List<int>>();  //dictionary of CHAR AND LIST to store multiple values to a single key as there can be duplicates in the key

            for (int charIterator = 0; charIterator < sortedKey.Length;charIterator++)
            {
                char temp = sortedKey[charIterator];
                if (dict.ContainsKey(temp))
                {                                   
                    dict[temp].Add(charIterator + 1);   //if the dict contains key, the list would have already been created so just add to it
                }
                else
                {
                    dict[temp] = new List<int> { charIterator+1 };// if it is not there, new create a new list obj and insert the value
                }
            }

            List<int> code = new List<int>();       //contains the final code 

            foreach(char c in key)
            { 
                code = code.Union(dict[c]).ToList();    // using union, if not the multiple values for a single key repeats
            }       
            string ans = "";
            int calc = 0;       //variable to calculate the iteration
            Boolean flag = false;
            while (true)
            {
                for (int charIterator = 0; charIterator < code.Count; charIterator++)
                {
                    int index = code.IndexOf(charIterator+1);

                    if (ans.Length >= message.Length)
                    {
                        flag = true;
                        break;
                    }
                    if(index + (key.Length * calc)< message.Length)
                    {
                        ans += message[index+(key.Length * calc)];   
                    }
                }
                if(flag)
                {
                    break;
                }
                calc++;

            }
            return (ans);
           
        }

        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string key = Console.ReadLine();
            Console.WriteLine(codeFinder(message, key));

        }
    }
}