using System;

namespace OperatorsAssignment
{
    // The Employee class represents a simple employee record
    // containing an ID, first name, and last name.
    public class Employee
    {
        // Each employee has a unique identification number.
        public int Id { get; set; }

        // The employee's first name.
        public string FirstName { get; set; }

        // The employee's last name.
        public string LastName { get; set; }

        // The "==" operator is overloaded to compare two employees by their Id.
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both objects are null, they are considered equal.
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If one object is null but not the other, they are not equal.
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Compare by the Id property.
            return emp1.Id == emp2.Id;
        }

        // The "!=" operator must also be overloaded when "==" is overloaded.
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Simply return the opposite of the "==" operator.
            return !(emp1 == emp2);
        }

        // Override Equals() to be consistent with the overloaded "==" operator.
        public override bool Equals(object obj)
        {
            // Check if the object is an Employee and compare Ids.
            if (obj is Employee other)
                return this.Id == other.Id;

            return false;
        }

        // Override GetHashCode() so it matches the Equals() method logic.
        public override int GetHashCode()
        {
            // Use the Id as the hash code since equality is based on Id.
            return Id.GetHashCode();
        }
    }
}
