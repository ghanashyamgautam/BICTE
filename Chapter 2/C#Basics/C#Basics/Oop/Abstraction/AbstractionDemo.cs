
namespace C_Basics.Oop.Abstraction
{
    public abstract class Animal
    {
        public string Name { get; set; }

        // Abstract method to be implemented by derived classes
        public abstract void MakeSound();

        // Regular method with implementation
        public void DisplayInfo()
        {
            Console.WriteLine($"Animal: {Name}");
        }
    }

    public class Dog : Animal
    {
        // Implementing the abstract method
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks: Woof! Woof!");
        }
    }

    public class Cat : Animal
    {
        // Implementing the abstract method
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows: Meow! Meow!");
        }
    }


    public class AbstractionDemo
    {
        Animal dog = new C_Basics.Oop.Abstraction.Dog { Name = "Buddy" };
        Animal cat = new C_Basics.Oop.Abstraction.Cat { Name = "Whiskers" };



        //dog.DisplayInfo();
        //    dog.MakeSound();

        //    cat.DisplayInfo();
        //    cat.MakeSound();
    }
}
