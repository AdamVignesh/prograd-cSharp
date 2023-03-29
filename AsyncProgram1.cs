namespace asyncProgramming1
{
    internal class Program
    {
        public static async Task<string> method1()
        {
            Console.WriteLine("method 1 starts");
            //Console.WriteLine("msg in method 1");
            Console.WriteLine(await method2());
            Console.WriteLine("method 1 ended");
            return "returned method1";
        }
        public static async Task<string> method2()
        {
            Console.WriteLine("method 2 starts");
            await Task.Delay(5000);
            string msg = "msg from method2";
            Console.WriteLine("method2 ends");
            return msg;
        }
        public static async Task<int> method3()
        {
            Console.WriteLine("helper method");
            return 5;
        }

        static void Main(string[] args)
        {
            method1();
            int ans = Program.method3().Result;
            Console.WriteLine("ans " + ans);
            Console.ReadLine();
        }
    }
}