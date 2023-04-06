using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nico_Cipher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Nico_Cipher.Tests
{
    [TestClass()]
    public class Nico_code_finderTests
    {
        [TestMethod()]
        public void codeFinderTest1()
        {
            string output = Nico_code_finder.codeFinder("mubashirhassan", "crazy");
            Assert.AreEqual("bmusarhiahassn",output);
        }
        [TestMethod()]
        public void codeFinderTest2()
        {
            string output = Nico_code_finder.codeFinder("edabitisamazing", "matt");
            Assert.AreEqual("deabtiismaaznig", output);
        }
        [TestMethod()]
        public void codeFinderTest3()
        {
            string output = Nico_code_finder.codeFinder("iloveher", "612345");
            Assert.AreEqual("lovehire", output);
        }
    }
}