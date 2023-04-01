using generics;

namespace generics
{
     internal class test<T>
    {
        public test(T message)
        {
            Console.WriteLine(message);
        }

    }
    class head
    {
        public static void Main()
        {
            test<string> gc = new test<string>("something");
            test<int> gc1 = new test<int>(150);
            test<float> gc2 = new test<float>(20.44f);
        }

    }
}
