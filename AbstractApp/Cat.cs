using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractApp
{
    internal class Cat : AbstractAnimal
    {
        public override void Eat()
        {
            base.Eat();                  // Κλήση της μεθόδου Eat() - virtual- από την AbstractAnimal
            Console.WriteLine($"{Name} the cat is eating.");
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }

        // Οπωσδήποτε override της ToString() γιατί είναι abstract στην AbstractAnimal
        public override string ToString()
        {
            return $"Cat: {Name}, Age: {Age}},";
        }
    }
    
}
