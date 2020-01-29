using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypeExample
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;
            isDeclared = true;
            bool isDeclarationAndInitialized = true;
           //NOTES\\
        }

        [TestMethod]
        public void Character()
        {
            char character = 'a';
            char symbol = '&';
            char number = '7';
            char space = ' ';
            char specialCharacter = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            sbyte sByteExample = -128;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 92233720385477;
            Int64 longMin = -92233720385477;

            int a = 15;
            int b = 22;
            int c = 37;
            byte age = 254;

        }
        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.045231f;
            double doubleExample = 1.78023432890d;
            decimal decimalExample = 1.2582380408580m;
            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);
        }

        enum PastryType { Cake, Danish, Doughnut, Scone, Cupcake, Croissant }

        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Doughnut;
            PastryType anotherOne = PastryType.Scone;
            Console.WriteLine(myPastry);
            Console.WriteLine(anotherOne);
        }

        [TestMethod]
        public void Structs()
        {
            Int32 age = 42;
            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            DateTime birthday = new DateTime(2020, 11, 24);
            Console.WriteLine(birthday);

        }

        [TestMethod]
        public void Challenges()
        {
            /*Declare 5-10 variables
            Initialize at least 5 of them. You cannot have more than 2 of any type. 
            Bonus: If you finish that make an enum. 
            Console Writeline all initialized values.*/

            bool isMale;
            isMale = true;
            Console.WriteLine(isMale);

            byte aByte = 250;
            Console.WriteLine(aByte);

            short aShort = -3482;
            Console.WriteLine(aShort);

            int aInt = 349;
            Console.WriteLine(aInt);

            float aFloat = 1.0820f;
            Console.WriteLine(aFloat);

            
        }
    }
}
