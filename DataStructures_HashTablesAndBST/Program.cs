﻿using System;

namespace DataStructures_HashTablesAndBST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the DataStructures HashTable and Binary Search Tree");
            //UC1 Ability to find frequency of number in sentence
            //string sentence = "To be or not to be";
            //CountNumbOfOccurence(sentence);
            //UC2 Ability to find frequency of words in a large paragraph phrase
           // string phrase = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
           // CountNumbOfOccurence(phrase);

            Console.WriteLine("Binary Search Tree");
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Insert(22);
            binarySearchTree.Insert(40);
            binarySearchTree.Insert(60);
            binarySearchTree.Insert(95);
            binarySearchTree.Insert(11);
            binarySearchTree.Insert(65);
            binarySearchTree.Insert(3);
            binarySearchTree.Insert(16);
            binarySearchTree.Insert(63);
            binarySearchTree.Insert(67);
            binarySearchTree.Display();
            binarySearchTree.GetSize();
            bool result = binarySearchTree.IfExists(63, binarySearchTree);
            Console.WriteLine(result);
        }
        public static void CountNumbOfOccurence(string Paragraph)
        {
            MyMapNode<string, int> hashtable = new MyMapNode<string, int>(6);
            string[] Words = Paragraph.Split(' ');
            foreach(string word in Words)
            {
                if(hashtable.Exists(word.ToLower())) 
                {
                    hashtable.Add(word.ToLower(), hashtable.Get(word.ToLower() + 1));
                }
                else
                {
                    hashtable.Add(word.ToLower() , 1);
                }
            }
            Console.WriteLine("Displaying after add operation");
            hashtable.Display();
            //UC3 Removing avoidable word from phrase
            hashtable.Remove("avoidable");
            Console.WriteLine("--------------------------");
            hashtable.Display();
        }
    }
}
