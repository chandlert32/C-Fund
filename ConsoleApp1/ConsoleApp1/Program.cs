

namespace ConsoleApp1

 Program
 {
        public void Strings()
        {
          string firstName = "Chandler";
          string lastName = "Tan";
          string concatenatedFullName = firstName + " " + lastName;
          Console.WriteLine(concatenatedFullName);

          string compositeFullName = string.Format("{0} + {1}", firstName, lastName);
          Console.WriteLine(compositeFullName);
        }
  }

