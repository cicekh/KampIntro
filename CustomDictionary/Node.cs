﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDictionary
{
    public class Node<T>
    {
        public T data;
        public Node(T data)
        {
            this.data = data;
        }
    }
}
