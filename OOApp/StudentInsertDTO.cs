using System;
using System.Collections.Generic;
using System.Text;

namespace OOApp
{
    /// <summary>
    /// Defines a StudentInsertDTO record class
    /// Public init-only properties for immutability
    /// Primary constructor to initialize the properties
    /// Value-based equality with == and != operators
    /// ToString() method for string representation
    /// </summary>
    /// <param name="Firstname"></param>
    /// <param name="Lastname"></param>
    internal record StudentInsertDTO(string? Firstname, string? Lastname)
    {
    }
}
