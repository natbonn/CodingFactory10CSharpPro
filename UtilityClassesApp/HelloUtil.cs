using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityClassesApp
{
    /// <summary>
    /// Utility class have static methods 
    /// that can be called without creating an instance of the class.
    /// </summary>
    internal static class HelloUtil
    {

        public static void SayHello()
        {
            Console.WriteLine($"Hello, Coding Factory!");
        }
    }
}
