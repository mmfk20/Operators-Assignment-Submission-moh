using System;

namespace EmployeeComparisonApp
{
    // Employee class definition
    public class Employee
    {
        // Properties for Employee class
        public int Id { get; set; }           // Unique identifier for an employee
        public string FirstName { get; set; } // First name of the employee
        public string LastName { get; set; }  // Last name of the employee

        // Overload the "==" operator to compare two Employee objects by their Id
        public static bool operator ==(Employee e1, Employee e2)
        {
            // Handle null checks to avoid exceptions
            if (ReferenceEquals(e1, null) && ReferenceEquals(e2, null))
                return true; // Both are null, so they are equal
            if (ReferenceEquals(e1, null) || ReferenceEquals(e2, null))
                return false; // One is null, the other is not

            return e1.Id == e2.Id; // Compare Id properties
        }

        // Overload the "!=" operator (must be overloaded in pairs)
        public static bool operator !=(Employee e1, Employee e2)
        {
            return !(e1 == e2); // Negation of "=="
        }

        // Override Equals method (recommended when overloading ==)
        public override bool Equals(object obj)
        {
            if (obj is Employee other)
                return this.Id == other.Id;
            return false;
        }

        // Override GetHashCode (recommended when overloading ==)
        public override int GetHashCode()
        {
            return Id.GetHa
