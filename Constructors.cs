namespace constructor_test
{
    internal class Program
    {
        string name;
        int age;
        string location;
        public Program ()
        {
            Console.WriteLine("this is a txt from default constructor");
        }
        public Program(string myName, int myAge, string myLocation)
        {
            name = myName;
            this.age = myAge;
            this.location = myLocation;
        }
        public void display()
        {
            Console.WriteLine($"the name is {name} and age is {age} and from {location}");
        }
        static void Main(string[] args)
        {
            Program pg = new Program();
            Program pg1 = new Program("Adam", 21, "karur");
            pg1.display();
            Program pg2 = new Program("Thas", 22, "Cbe");
            pg2.display();
        }
    }
}