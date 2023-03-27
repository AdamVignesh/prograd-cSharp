namespace fileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FileStream file = new FileStream("C:\\Users\\HP\\Desktop\\Happiness\\fileHandling.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

           /* using (TextWriter writerText = File.CreateText("C:\\Users\\HP\\Desktop\\Happiness\\fileHandling.txt")) 
            {
                writerText.WriteLine("yes i'm back ");
                *//*
            }*/
            using (TextReader readerText = File.OpenText("C:\\Users\\HP\\Desktop\\Happiness\\fileHandling.txt"))
            {
                Console.WriteLine(readerText.ReadToEnd());
            }
           // StreamWriter writer = new StreamWriter(file);
            //writer.WriteLine("Hi from adam");
           // StreamReader reader = new StreamReader(file);
            //Console.WriteLine(reader.ReadToEnd());
            //string content  = reader.ReadToEnd();
           // Console.WriteLine(content);
            //reader.Close();
            //writer.Close();
            //file.Close();
        }

        

    }
}