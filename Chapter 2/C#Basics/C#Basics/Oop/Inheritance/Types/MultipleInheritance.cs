using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics.Oop.Inheritance.Types.Multiple
{
    public interface IAnimal
    {
        void Eat();
    }

    public interface IPet
    {
        void Play();
    }

    public class Dog : IAnimal, IPet
    {
        public void Eat() { Console.WriteLine("Eating..."); }

        public void Play() { Console.WriteLine("Playing..."); }
    }

}
