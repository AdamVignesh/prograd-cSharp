namespace Delegates
{
    delegate int delegateForCalc(int n1, int n2);
    delegate void delegateForTesting(string testMsg);
    internal class Program
    {
        static void Main(string[] args)
        {
            delegateForTesting t1 = test;
            t1 += unitTest;
            t1("Hi this is testing team here to test this code");
            delegateForCalc d1 = add;
            d1 += diff;     //adding other functions to the same delegate
            d1 += mul;
            d1 -= add;      // to remove one method from delegate
            //Console.WriteLine(d1(2, 3));
            foreach(delegateForCalc a in d1.GetInvocationList())
            {                                                          // if the methods return values this is the method to call
                Console.WriteLine(a.Invoke(2,3));
            }
            //d1.Invoke(2, 3);    //another way of calling for void methods
        }
        static void test(string testMsg)
        {
            Console.WriteLine(testMsg);
        }
        static void unitTest(string testMsg)
        {
            Console.WriteLine(testMsg+" - unitTesting team");
        }
        static int add(int n1, int n2)
        {
            return (n1 + n2);
        }
        static int diff(int n1, int n2)
        {
            return(n1 - n2);
        }
        static int mul(int n1, int n2) 
        {
            return(n1 * n2);    
        }
    }
}