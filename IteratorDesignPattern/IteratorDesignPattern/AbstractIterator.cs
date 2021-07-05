using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorDesignPattern
{
    interface AbstractIterator
    {
        Student First();
        Student Next();
        bool IsCompleted { get; }
    }
}
