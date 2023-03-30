using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator_test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace calculator_test.Tests
{
    [TestFixture()]
    public class ProgramTests
    {
        [TestCase(2,3)]
        [TestCase(3,3)]
        public void mulTest(int x,int y)
        {
            int res = Program.mul(x,y);
            NUnit.Framework.Assert.AreEqual(6,res);
        }
    }
}