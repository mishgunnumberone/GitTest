using System;
namespace GitTest
{
    public class Person
    {
        string Name;
        int Age;

        public void sayHello() {
            Console.WriteLine("Hello, there!");
        }

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}
