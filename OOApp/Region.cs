using System;
using System.Collections.Generic;
using System.Text;

namespace OOApp
{
    // with sealed keyword, the class cannot be inherited. Strict immutability.
    // This is useful for security and performance reasons.
    internal sealed class Region
    {
        public int Id { get; }
        public string? Name { get; }

        public Region()
        {

        }

        public Region(int id, string? name)
        {
            Id = id;
            Name = name;
        }

    }
}
