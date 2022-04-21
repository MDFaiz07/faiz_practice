using System;

namespace faiz_practice
{
    class Program
    {
        //polymorphism_methodOverloading
        public class Animal
        {
            public Animal()
            {
                Console.WriteLine("Eating...");
            }
        }
        public class basic: Animal
        {
            public basic()
            {
                Console.WriteLine("Eating  food...");
            }
        }
        public class Dog : Animal
        {
            public  Dog()
            {
               
                Console.WriteLine("Eating bread...");
            }
        }
        public class TestOverriding
        {
            public static void Main()
            {
                Dog d = new Dog();
                basic obj = new basic();
             
            }
        }
    }
}
