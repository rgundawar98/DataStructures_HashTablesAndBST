using System;

namespace DataStructures_HashTablesAndBST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the DataStructures HashTable and Binary Search Tree");
            //UC1 Ability to find frequency of number in sentence
            string sentence = "To be or not to be";
            CountNumbOfOccurence(sentence);
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
        }
    }
}
