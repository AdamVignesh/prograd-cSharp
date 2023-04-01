using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    internal class Class1
    {
        public void meth<T>(T message)
        {
            Console.WriteLine(message);
        }
    }

    class Test
    {
        static void Main()
        {
            Class1 obj = new Class1();
            obj.meth("this is a string");
            obj.meth(150);
            obj.meth(43.432f);
        }
    }
}
