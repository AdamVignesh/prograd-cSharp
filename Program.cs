using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_play_exp
{
    public class Program
    {
        public void method1()
        {
            var obj1 = new Program1();
            /*obj1.method2();*/
            Console.WriteLine("hello from program class");
        }
        public class Program1
        {
            protected internal string name = "Adam";
            protected internal void method2(string msg)
            {
                Console.WriteLine(msg);
            }
        }
        
    }

}