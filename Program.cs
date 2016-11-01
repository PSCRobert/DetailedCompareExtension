using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var emp1 = new Employee() 
            {
                Id = 1,
                Forename = "John",
                Surname = "Smith",
                DateOfBirth = new DateTime(1992, 01, 02)
            };

            var emp2 = new Employee() 
            {
                Id = 1,
                Forename = "Jane",
                Surname = "Dale",
                DateOfBirth = new DateTime(1944, 07, 30)
            };

            List<Variance> changes = emp1.DetailedCompare(emp2);

            foreach (var change in changes)
            {
                Console.WriteLine("{0} - Old: {1}, New: {2}", change.Prop, change.valA, change.valB);
            }
        }
    }
}
