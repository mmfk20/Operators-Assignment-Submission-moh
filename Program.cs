using System;

namespace EmployeeComparisonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate first Employee object and assign property values
            Employee employee1 = new Employee
            {
                Id = 101,
                FirstName = "Alice",
                LastName = "Smith"
            };

            // Instantiate second Employee object and assign property values
            Employee employee2 = new Employee
            {
                Id = 102,
                FirstName = "Bob",
                LastName = "Johnson"
            };

            // Compare the two Employee objects using the overloaded "==" operator
            if (employee1 == employee2)
            {
                Console.WriteLine("The employees are equal (same Id).");
            }
            else
            {
                Console.WriteLine("The employees are NOT equal (different Ids).");
            }

            // Compare the two Employee objects using the overloaded "!=" operator
            if (employee1 != employee2)
            {
                Console.WriteLine("The employees are different (Ids do not match).");
            }
            else
            {
                Console.WriteLine("The employees are the same (Ids match).");
            }

            // Wait for user input to keep console open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
