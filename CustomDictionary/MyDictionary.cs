using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDictionary
{
    public class MyDictionary<TKey, TData>
    {

        public MyDictionary()
        {
            Count = 0;
        }

        public HashNodeMap<TData> hashNode = null;
        public int Count;

        public object this[TKey s]
        {
            get { return FindHashCode(s).data; }
            set { }
        }

        private HashNodeMap<TData> CreateNode(TKey key, TData data)
        {
            int hashCode = key.GetHashCode();
            HashNodeMap<TData> newNodeMap = new HashNodeMap<TData>();
            newNodeMap.data = new Node<TData>(data);
            newNodeMap.key = hashCode;
            return newNodeMap;
        }

        public void Add(TKey key, TData data)
        {
            HashNodeMap<TData> current = null;
            if (hashNode == null)
            {
                hashNode = CreateNode(key, data);
            }
            else
            {
                current = hashNode;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = CreateNode(key, data);
            }
            Count++;
        }
        private Node<TData> FindHashCode(TKey key)
        {
            Node<TData> data = null;
            int hashCode = key.GetHashCode();
            HashNodeMap<TData> current = hashNode;

            while (current != null)
            {
                if (current.key == hashCode)
                {
                    data = current.data;
                    break;
                }
                if (current.next != null)
                {
                    current = current.next;
                }
            }
            return data;
        }
    }
}
