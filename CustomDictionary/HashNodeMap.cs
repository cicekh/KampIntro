using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDictionary
{
    public class HashNodeMap<T>
    {
        public int key;
        public Node<T> data;
        public HashNodeMap<T> next;
    }
}
