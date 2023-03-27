using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_play_exp
{
    public class Inheritance
    {
        internal void  wheels()
        {
            Console.WriteLine("This car has 4 wheels");
        }
        public void accelerate()
        {
            Console.WriteLine("This car can accelerate");
        }
        
    }

    public class Tesla : Inheritance
    {
        public void autoPilot()
        {
            Console.WriteLine("This car has Auto Pilot mode");
        }

    }

    public class TeslaSport : Tesla
    {
        public void sportMode()
        {
            Console.WriteLine("This car has a sport mode");
        }
    }
}
