namespace asyncProgramming
{
    internal class asyncProgramming
    {
        static async Task Main(string[] args)
        {
            FirstMethod();
            Task<string> resultantNumber = ReturnNumber();
            await resultantNumber;
            Console.WriteLine($"The number = {resultantNumber.Result} ");
            SecondMethod();
            Console.ReadLine();
        }

        public static async void FirstMethod()
        {

            Console.WriteLine("Method1 has started");
            await Task.Delay(3000);
            Console.WriteLine("Method1 has Ended");
        }

        public static async Task<string> ReturnNumber()
        {

            Thread.Sleep(7000);
            return "jyg";
        }

        public static  void SecondMethod()
        {
            Console.WriteLine("Method2 has started");
            Console.WriteLine("Method2 has Ended");
        }
    }
}