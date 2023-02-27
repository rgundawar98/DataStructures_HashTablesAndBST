using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_HashTablesAndBST
{
    public class MyMapNode<K , V>
    {
        public struct keyValue<k , v>
        {
            public K key { get; set;}
            public V value { get; set;}
        }
        private readonly int size;
        private readonly LinkedList<keyValue<K, V>>[] items;
        public MyMapNode(int size)
        {
            this.size = size;
            this.items= new LinkedList<keyValue<K, V>>[size];
        }
        protected int GetArrayPosition(K key)
        {
            int hash = key.GetHashCode();
            int Position = hash % size;
            return Math.Abs(Position);
        }
        public V Get(K key)
        {
            var LinkedList = GetArrayPositionAndLinkedList(key);
            foreach(keyValue<K, V> item in LinkedList)
            {
                if(item.key.Equals(key))
                    return item.value;
            }
            return default(V);
        }
        public void Add(K key , V value)
        {
            var LinkedList = GetArrayPositionAndLinkedList(key);
            keyValue<K,V> item= new keyValue<K,V>() { key=key, value=value };
            if(LinkedList.Count !=0)
            {
                foreach(keyValue<K,V> item1 in LinkedList)
                {
                    if(item1.key.Equals(key))
                    {
                        Remove(key);
                        break;
                    }
                }
            }
            LinkedList.AddLast(item);
        }
        public bool Exists(K key)
        {
            var LinkedList = GetArrayPositionAndLinkedList(key);
            foreach(keyValue<K,V> item in LinkedList)
            {
                if(item.key.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }
        public LinkedList<keyValue<K , V>> GetArrayPositionAndLinkedList(K key)
        {
            int Position = GetArrayPosition(key);
            LinkedList<keyValue<K, V>> linkedlist = GetLinkedList(Position);
            return linkedlist;
        }
        public void Remove(K key)
        {
            var LinkedList = GetArrayPositionAndLinkedList(key);
            bool itemFound = false;
            keyValue<K,V> foundItem = default(keyValue<K,V>);
            foreach(keyValue<K,V> item in LinkedList)
            {
                if(item.key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if(itemFound)
            {
                LinkedList.Remove(foundItem);
            }
        }
        protected LinkedList<keyValue<K,V>> GetLinkedList(int Position)
        {
            LinkedList<keyValue<K,V>> LinkedList = items[Position];
            if (LinkedList == null)
            {
                LinkedList = new LinkedList<keyValue<K,V>>();
                items[Position] = LinkedList;
            }
            return LinkedList;
        }
        public void Display()
        {
            foreach(var LinkedList in items)
            {
                if (LinkedList != null)
                {
                    foreach(var element in LinkedList)
                    {
                        string res = element.ToString();
                        if (res != null)
                            Console.WriteLine(element.key+" "+element.value);
                    }
                }
            }
        }

    }
}
