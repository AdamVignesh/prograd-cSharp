namespace collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> d = new Dictionary<int, string>();
            d.Add(1, "vignesh");
            d.Add(2, "adam");
            d.Add(3, "madhu");
            d.Add(4, "prabu");
            d.Add(5, "rahul");
            d.Add(6, "rahul");
            d.Add(7, "");
            
            foreach (KeyValuePair<int, string> kvp in d)

            { 
                if(kvp.Value.Equals("adam"))
                {
                    d[kvp.Key]=  "ADAM";
                    
                }
            }

            foreach (KeyValuePair<int, string> kvp in d)

            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
        }
    }
}