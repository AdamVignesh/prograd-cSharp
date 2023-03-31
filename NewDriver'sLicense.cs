using Microsoft.VisualBasic;

namespace NewDriver_sLicense
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter my Name");
            string myName = Console.ReadLine();
            Console.WriteLine("Enter the number of available agents");
            int availableAgents = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the other four names with space");
            string fourNames = Console.ReadLine();

            string[] namesArray = fourNames.Split();
            List<string> names = new List<string>();
            names.Add(myName);
            foreach(string name in namesArray)
            {
                names.Add(name);
            }

            List<string> sortedNameList= names.OrderBy(n=>n).ToList();
            int batchCount = 0;
            
            string res = "";


            int nameIteration = 0;
                for (nameIteration = availableAgents * batchCount; nameIteration < availableAgents * batchCount + (availableAgents); nameIteration = nameIteration+availableAgents)
                {
                    if (nameIteration >= sortedNameList.Count() || sortedNameList[nameIteration]==myName)
                    {
                        break;
                    }
                   
                }
                

            Console.WriteLine($"I''ll get my license at{nameIteration * 20}");
        }
    }
}