using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorDesignPattern
{
    class ConcreteCollection : AbstractCollection
    {
        private List<Student> listStd = new List<Student>();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        public int Count
        {
            get { return listStd.Count; }
        }

        //Add items to the collection
        public void AddStudent(Student std)
        {
            listStd.Add(std);
        }

        //Get item from collection
        public Student GetStudent(int index)
        {
            return listStd[index];
        }

    }
}
