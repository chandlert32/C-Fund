using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_Practice
{
    [TestClass]
    public class Freewrite
    {
        [TestMethod]
        public void InterpolationPractice()
        {
            string cheese = "string cheese";
            string pasta = "mac and cheese";
            string beans = "kidney beans";
            string interpolatedFull = ($"Hey, I would like to order {cheese}, {pasta}, and {beans} please!");
            Console.WriteLine(interpolatedFull);
        }

        [TestMethod]
        public void ConcatenatePractice()
        {
            string variable = "Hello";
            string concatenatedFull = variable + " world, and " + variable + " class. Welcome to the gold badge.";
            Console.WriteLine(concatenatedFull);
        }
        /*
        [TestMethod]
        public void Collections()
        {
            string
        }
        */

        [TestMethod]
        public void IfStatement()
        {
            int sleepHours = 10;
            if (sleepHours < 8) ;
            {
                Console.WriteLine("I am tired.");
            }
            if (sleepHours > 20);
            {
                Console.WriteLine("I might be in a come.");
            }
        }

        [TestMethod]
        public void Ternaries()
        {
            int volumeLevel = 10;


        }
    }
}
