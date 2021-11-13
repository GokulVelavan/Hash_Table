using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    class Program
    {
        //static method to count frequency of word
        public static void CountWordFrequency(string sentence)
        {
            //declaring datatype for key and value
            MapNode<string, int> hashtable = new MapNode<string, int>(10);
            
          
           

            //spliting the sentence to generate keys
            string[] words = sentence.Split();

            foreach (string word in words)
            {
                if (hashtable.Exists(word))
                {
                    //if it exist then get value of linkedList object
                    hashtable.Add(word, hashtable.Get(word) + 1);
                }
                else
                {
                    hashtable.Add(word, 1);
                }
            }
            Console.WriteLine("Displaying after add operation\n");
            hashtable.Display();
            Console.WriteLine("-----------------------------------------");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Hash Table");
            string wordInSentence = "hello world hello world";
            CountWordFrequency(wordInSentence);
            Console.ReadLine();
        }
    }
}
