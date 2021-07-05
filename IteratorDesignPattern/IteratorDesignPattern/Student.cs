using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorDesignPattern
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Student(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }
}
