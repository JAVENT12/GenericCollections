using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollections
{
    public class Collections<T> //Using type parameters! To use an accurate refecrence, I used explanations of each data structure are from Microsoft Visual C#, Step by Step 9th Ed
    {
        public  void PrintList(T [] ints)
        {
            List<T> numbers = new List<T>(); // Unlike arrays, you can shrink or expand Lists
                                             // There are also more methods in a List, to support searching and sorting operations    
            foreach(T number in ints)
            {
                numbers.Add(number);      // Adding to the List                       
            }
            foreach(T num in numbers)
            {
                Console.WriteLine("Printing from the List!");
                Console.WriteLine(num); 
            }
            Console.WriteLine();
        }
        public void PrintLinkedList(T [] words)
        {
            LinkedList<T> wurds = new LinkedList<T>(); // A double-ended ordered list, optimized to support insertion and removal at either end
                                                         // This collection can act like a queue or a stack, but it also supports random access as a list does.  
            foreach (T word in words)// 
            {
                wurds.AddLast(word);  // Adding to the LinkedList 
            }
            for(LinkedListNode<T> node = wurds.First; node != null; node = node.Next) //foreach also works
            {
                T wurd = node.Value;
                Console.WriteLine("Printing from the LinkedList"); 
                Console.WriteLine(wurd); 
            }
            Console.WriteLine();
        }
        public void PrintQueue(T [] chars)
        {
            Queue<T> letters = new Queue<T>(); // A first-in, first-out data structure, with methods to add an item to one end of the queue
                                               // remove an item from the other end, and examine an item without removing it.
            foreach (T L in chars)
            {
                letters.Enqueue(L); //Adding to the Queue
            }
            foreach(T L in letters)
            {
                Console.WriteLine("Printing from the Queue");
                Console.WriteLine(L);  
            }
            while(letters.Count > 0)
            {
                T L = letters.Dequeue();
                Console.WriteLine($"{L} is leaving the Queue");
            }
            Console.WriteLine();
        }
        public  void PrintStack(T [] nums)
        {
           Stack<T> doubles = new Stack<T>(); // A first-in, last-out data structure with methods to push an item onto the top of the stack
                                              // pop an item from the top of the stack and examine the item at the top of the  stack without removing it.
            foreach (T num in nums)
            {
                doubles.Push(num);
            }
            foreach(T num in doubles)
            {
                Console.WriteLine("Printing from the stack!");
                Console.WriteLine(num);
            }
             //   while(doubles.Count > 0)
             // {
             //    T num = doubles.Pop();
             //   Console.WriteLine($"{num} has been popped off the stack");
             //}
            Console.WriteLine();
        }
       public void PrintDictionary(T [] pairs) // A collection of values that can be identifi ed and retrieved by using keys rather than indexes.
        {
            Dictionary<T, T> logBook = new Dictionary<T, T>();
            logBook[pairs[0]] = pairs[1];
            logBook[pairs[2]] = pairs[3];
            logBook[pairs[4]] = pairs[5];
            logBook[pairs[6]] = pairs[7];
            logBook[pairs[8]] = pairs[9];

            foreach(KeyValuePair<T,T> pair in logBook)
            {
                Console.WriteLine("Printing from the Dictionary!");
                T name = pair.Key;
                T age = pair.Value;
                Console.WriteLine($"Name: {name}, Age: {age}");
            }
            Console.WriteLine();
        }
        public void PrintHashList(T [] names) // An unordered set of values that is optimized for fast retrieval of data.
        {                                     // It provides set - oriented methods      
            HashSet<T> employees = new HashSet<T>();
            employees.Add(names[0]);
            employees.Add(names[1]);
            employees.Add(names[2]);
            employees.Add(names[3]);
            employees.Add(names[4]);

            foreach(T name in employees)
            {
                Console.WriteLine("Printing from the Hashset!");
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }

        public void PrintSortedList(T [] keyPairs) // A sorted list of key/value pairs
        {
            SortedList<T, T> people = new SortedList<T, T>();
            people[keyPairs[0]] = keyPairs[1];
            people[keyPairs[2]] = keyPairs[3];
            people[keyPairs[4]] = keyPairs[5];
            people[keyPairs[6]] = keyPairs[7];
            people[keyPairs[8]] = keyPairs[9];

            foreach (KeyValuePair<T, T> pair in people) 
            {
                Console.WriteLine("Printing from the SortedList!");
                T name = pair.Key; //Keys assorted alphabetically
                T age = pair.Value;
                Console.WriteLine($"Name: {name}, Age: {age}");
            }
            Console.WriteLine();
        }
    }
}
