
using System;

class Program
    {
        public void Strings()
        {
            string firstName = "Chandler";
            string lastName = "Tan";
            string concatenatedFullName = firstName + " " + lastName;
            Console.WriteLine(concatenatedFullName);

            string compositeFullName = string.Format("{0} + {1}", firstName, lastName);
            Console.WriteLine(compositeFullName);

          w  string interpolatedFullName = ($"Hello {firstName} {lastName}. Whatever I wanted. {firstName}");
            Console.WriteLine(interpolatedFullName);
        }

        [TestMethod] 
        public void: Collections()
        { 
            string stringExample = "Hello World";
            string[] stringArray = { "Hello", "World", "Why", "is it", "always", stringExample, "?" };

            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);

            stringArray[0] = "hey there";
        Console.WriteLine(stringArray[0]);

        
        }
    }

