using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic_GetEnumerator_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Non Generic Collections
            /* Non - generic collections accept data of any type. */
            ArrayList nonGenericList = new ArrayList();

            // Generic Collection
            /* Generic collection accepts data of only one type */
            List<string> studentList = new List<string>();

            studentList.Add("a");
            studentList.Add("b");

            foreach (var item in studentList)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < studentList.Count; i++)
            {
                Console.WriteLine(studentList[i]);
            }

            // Non Geneceric Collection-dir.
            Stack stack = new Stack();
            stack.Push(5);
            stack.Push("StackOverFlow");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            // ----------------------- QUEUE ----------------------------------

            Queue<string> queue = new Queue<string>();

            //   Melumat elave etmek ucun Enqueue()-dan melumati oxumaq cun ise Dequeue()-dan istifade olunur

            queue.Enqueue("You turn ");
            queue.Enqueue("He turn ");
            queue.Enqueue("She turn ");
            queue.Enqueue("We turn ");
            queue.Enqueue("They turn ");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            // ----------------------- DICTIONARY ----------------------------------

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add("Seyid", 32);
            dictionary.Add("Elnare", 27);
            dictionary.Add("Xatire", 29);

            Console.WriteLine(dictionary["Elnare"]);
            Console.WriteLine(dictionary["Xatire"]);

            // ----------------------- SORTEDLIST ----------------------------------

            // Dictionaryden ferqli olaraq burda axtaris key-e goredir Dictionary-de ise stringe goredir.

            SortedList<int, string> keyValuePairs = new SortedList<int, string>();

            keyValuePairs.Add(32, "Seyid");
            keyValuePairs.Add(27, string.Format("Elnare"));
            keyValuePairs.Add(29, string.Join("Xatire"));
            Console.WriteLine(keyValuePairs[32]);
            Console.WriteLine(dictionary["Xatire"]);

            // ----------------------- HashSet ----------------------------------

            HashSet<string> hashset = new HashSet<string>();

            hashset.Add("Seyid");
            hashset.Add("Seyid122493");
            hashset.Add("Seyid");
            hashset.Add("Elnare");
            hashset.Add("Fazil");
            hashset.Add("Nadir");

            // HashSet uniqe melumat saxlayir add olunanlardan tekrar olunanlari elave etmir.

            // ----------------------- LINKEDLIST ----------------------------------


            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddLast(32);
            linkedList.AddFirst(5);
            linkedList.AddAfter(linkedList.Find(5), 6);
            linkedList.AddBefore(linkedList.Find(32), 7);
            linkedList.AddAfter(linkedList.Find(32), 13);
        }
    }

    // burada yazilan B ve T yuxarida cagirilanda hansi tip verilirse o tip classa set olunur.
    class MyGeneric<T> where T : IEatableFruits, new()
    {
        public T Name { get; set; }
        public void GetValue(T info)
        {
            Console.WriteLine(info); ;
        }
        public MyGeneric(T _name)
        {
            this.Name = _name;
            Console.WriteLine(Name);
        }
    }

    interface IEatableFruits
    {

    }

    class Apple : IEatableFruits
    {
        public string Name { get; set; }
    }
}
