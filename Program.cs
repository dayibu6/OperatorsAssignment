using System;

namespace OperatorsAssignment
{
    // The Program class contains the Main method — the entry point of the console application.
    class Program
    {
        static void Main(string[] args)
        {
            // Display a title for clarity when running in the console.
            Console.WriteLine("=== Employee Operator Overloading Example ===\n");

            // Create the first Employee object and assign property values.
            Employee emp1 = new Employee()
            {
                Id = 101,                // Employee ID
                FirstName = "Alice",     // Employee's first name
                LastName = "Johnson"     // Employee's last name
            };

            // Create the second Employee object and assign values.
            Employee emp2 = new Employee()
            {
                Id = 101,                // Same ID to test equality
                FirstName = "Bob",       // Different first name
                LastName = "Smith"       // Different last name
            };

            // Compare the two Employee objects using the overloaded "==" operator.
            bool areEqual = emp1 == emp2;

            // Display the comparison result to the user.
            Console.WriteLine($"Are Employee 1 and Employee 2 equal by Id? {areEqual}");

            // Also test the "!=" operator to confirm opposite behavior.
            bool areNotEqual = emp1 != emp2;

            // Display the result of the "!=" comparison.
            Console.WriteLine($"Are Employee 1 and Employee 2 not equal? {areNotEqual}");

            // End of program message.
            Console.WriteLine("\nPress any key to close...");
        }
    }
}
