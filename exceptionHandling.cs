namespace exceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 23;
            int b = 0;

            try
            {
                int c = a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("you cannot try to divide by 0");
            }
            catch (Exception e)
            {
                Console.WriteLine("exception caught " + e);
            }
            finally
            {
                Console.WriteLine("Whatever happens......finally executes");
            }
            try
            {
                checkAge(14);
            }
            catch(Exception e) 
            {
                Console.WriteLine(e);
            }

        }
            public static void checkAge(int age)
            {
                if (age < 18)
                {
                    throw new Exception("you should be above 18 to vote");
                }

            }
            public class myException : Exception
            {
                public myException(string message) : base(message)
                {

                }
            }
    
    }
    
    
}