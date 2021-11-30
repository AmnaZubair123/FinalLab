using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using salarymethod;

namespace CalculateSalary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Employee()
        {
            Console.WriteLine("Enter your id:");
            string id = Console.ReadLine();
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter which type of employee you are:");
            string type = Console.ReadLine();
            Console.WriteLine("Enter the hour you have worked:");
            string hourworked = Console.ReadLine();

            
        }
    }
}
