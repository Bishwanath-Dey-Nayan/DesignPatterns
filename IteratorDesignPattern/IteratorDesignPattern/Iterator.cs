using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorDesignPattern
{
    class Iterator : AbstractIterator
    {
        private ConcreteCollection collection;
        private int current = 0;
        private int step = 1;

        public Iterator(ConcreteCollection collection)
        {
            this.collection = collection;
        }

        public Student First()
        {
            current = 0;

            return collection.GetStudent(current);
        }

        public Student Next()
        {
            current += step;
            if (!IsCompleted)
            {
                return collection.GetStudent(current) ;
            }
            else
            {
                return null;
            }
        }

        // Check whether iteration is complete
        public bool IsCompleted
        {
            get { return current >= collection.Count; }
        }
    }
}
