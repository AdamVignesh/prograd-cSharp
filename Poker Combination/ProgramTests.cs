using Microsoft.VisualStudio.TestTools.UnitTesting;
using PockerGame;
using PokerCombination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PockerGame.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        PokerGame pokerObj = new PokerGame();

        [TestMethod]
        public void TestRoyalFlush()
        {
            string[] deck = { "10h", "Jh", "Qh", "Ah", "Kh" };
            string output = PokerGame.handlePoker(deck);       
            Console.WriteLine(output);
            Assert.AreEqual("It is a Royal Flush", output);
        }
        [TestMethod]
        public void TestStraightFlush()
        {
            string[] deck = { "Js", "10s", "9s", "8s", "7s" };
            string output = PokerGame.handlePoker(deck);
            Console.WriteLine(output);
            Assert.AreEqual("It is a Straight Flush", output);
        }
        [TestMethod]
        public void TestFourOfAKind()
        {
            string[] deck = { "5s", "5d", "5h", "5c", "2d" };
            string output = PokerGame.handlePoker(deck);
            Console.WriteLine(output);
            Assert.AreEqual("It is Four of a Kind", output);
        }
        [TestMethod]
        public void TestFullHouse()
        {
            string[] deck = { "6c", "6h", "6d", "Ks", "Kh" };
            string output = PokerGame.handlePoker(deck);
            Console.WriteLine(output);
            Assert.AreEqual("It is a Full House", output);
        }
        [TestMethod]
        public void TestFlush()
        {
            string[] deck = { "Jd", "9d", "8d", "4d", "3d" };
            string output = PokerGame.handlePoker(deck);
            Console.WriteLine(output);
            Assert.AreEqual("It is Flush", output);
        }
        [TestMethod]
        public void TestStraight()
        {
            string[] deck = { "10d", "9c", "8h", "7d", "6s" };
            string output = PokerGame.handlePoker(deck);
            Console.WriteLine(output);
            Assert.AreEqual("It is straight", output);
        }
        [TestMethod]
        public void TestThreeOfAKind()
        {
            string[] deck = { "Qs", "Qc", "Qh", "9h", "2c" };
            string output = PokerGame.handlePoker(deck);
            Console.WriteLine(output);
            Assert.AreEqual("It is Three of a Kind", output);
        }
        [TestMethod]
        public void TestTwoPair()
        {
            string[] deck = {  "Js", "Jh", "3s", "3c", "2h" };
            string output = PokerGame.handlePoker(deck);
            Console.WriteLine(output);
            Assert.AreEqual("It is a Two Pair", output);
        }
        [TestMethod]
        public void TestOnePair()
        {
            string[] deck = { "10c", "10h", "8c", "7h", "4s" };
            string output = PokerGame.handlePoker(deck);
            Console.WriteLine(output);
            Assert.AreEqual("It is a Pair", output);
        }
        [TestMethod]
        public void TestHighCard()
        {
            string[] deck = { "Kd", "Qd", "8c", "4c", "3h" };
            string output = PokerGame.handlePoker(deck);
            Console.WriteLine(output);
            Assert.AreEqual("It is High Card", output);
        }


    }
}