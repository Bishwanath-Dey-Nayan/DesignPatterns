using System;

namespace IteratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating collection
            ConcreteCollection col = new ConcreteCollection();

            col.AddStudent(new Student ("Sam", 100));
            col.AddStudent(new Student("Ram", 101));
            col.AddStudent(new Student("Tam", 102));
            col.AddStudent(new Student("Jam", 103));

            //creating Iterator
            Iterator iterator = col.CreateIterator();

            for(Student std = iterator.First(); !iterator.IsCompleted; std = iterator.Next())
            {
                Console.WriteLine($"ID : {std.ID}, Name: {std.Name}");
            }

            Console.ReadKey();

        }
    }
}
