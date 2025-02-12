using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics.Oop.Inheritance.Level.Multi
{
    public class Animal
    {
        public void Eat() { Console.WriteLine("Eating..."); }
    }

    public class Dog : Animal
    {
        public void Bark() { Console.WriteLine("Barking..."); }
    }

}
