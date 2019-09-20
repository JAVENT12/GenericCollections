using System;
using System.Collections.Generic;

namespace GenericCollections
{
    public class Program 
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SD6!");
            int[] ints= { 1, 2, 3, 4, 5 };
            var IntList = new Collections<int>(); // Inserting int data type into this object
            IntList.PrintList(ints);                  // Collections<ThreadStaticAttribute>.PrintList();

            string [] words = { "Dan", "is", "the", "Man", "!" };
            var StringList = new Collections<string>(); // Inserting string data type into this object
            StringList.PrintLinkedList(words);

            char[] chars = { 'U', 'S', 'M', 'C', '!' };
            Collections<char> CharList = new Collections<char>(); // Inserting chars into this object
            CharList.PrintQueue(chars);

            double[] nums = {21.71, 17.76, 18.2, 20.14, 20.19};
            Collections<double> DoubleList = new Collections<double>(); // Inserting doubles into this object
            DoubleList.PrintStack(nums);

            object[] pairs = { "Dan", 40, "Bob", 29, "Chad", 27, "Brad", 24, "Jorge", 25};
            Collections<object> DictionaryList = new Collections<object>(); // Inserting anything into this object
            DictionaryList.PrintDictionary(pairs); // T Key and TValue

            string[] names = { "Dan","Bob", "Chad", "Brad", "Jorge" };
            Collections<string> HashList = new Collections<string>(); // Inserting anything into this object
            HashList.PrintHashList(names); // T Key and TValue

            object[] keyPairs = { "Juan", 25, "Jose", 24, "Etan", 22, "Omar", 22, "Hector", 29 };
            Collections<object> SortedList = new Collections<object>(); // Inserting anything into this object
            SortedList.PrintSortedList(keyPairs);
        }
    }
}
