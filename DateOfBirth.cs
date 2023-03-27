namespace dob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your dob");

            string dob = Console.ReadLine();
            DateTime birthDay;
            try
            {
                birthDay = DateTime.Parse(dob);
                DateTime now = DateTime.Today;
                int age = now.Year - birthDay.Year;
                int DiffInMonth =  birthDay.Month - now.Month ;
                if(DiffInMonth<0)
                {
                    Console.WriteLine("u recently celebrated your birthday");
                }
                else if(DiffInMonth>=0 && DiffInMonth<2)
                {
                    Console.WriteLine("advance happy birthday");
                }
                else
                {
                    Console.WriteLine("your bday is comming sooooon");
                }
                Console.WriteLine("AGE: " + age);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}