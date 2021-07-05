using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorDesignPattern
{
    interface AbstractCollection
    {
        Iterator CreateIterator();
    }
}
