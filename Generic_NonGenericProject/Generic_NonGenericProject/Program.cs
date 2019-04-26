using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic_NonGenericProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Non Generic COLLECTION Data..");
            Console.WriteLine(" \n ARRAY LIST");

            // arraylist
            ArrayList List = new ArrayList();
            string str = "unspoken Dreams";
            int x = 4;
            List.Add(str);
            List.Add(x);
            // printing the array list
            foreach (var item in List)
            {
                Console.WriteLine(item);
            }

            // HASH CODE
            Console.WriteLine(" \n HASH DATA");
            Hashtable HashObj = new Hashtable();
            HashObj.Add(1, "Shantanu");
            HashObj.Add(2, "Bonzi");
            HashObj.Add(3, "unspoken Dreams");
            ICollection KeySortedList_Key = HashObj.Keys;
            // PRINTING THE HASH CODE
            foreach (var val in KeySortedList_Key)
            {
                Console.WriteLine(val + "-" + HashObj[val]);
            }

            // SORTEDLIST CODE
            Console.WriteLine(" \n SORTEDLIST");
            SortedList SortList = new SortedList();
            SortList.Add("1", "Shantanu");
            SortList.Add("5", "Bonzi");
            SortList.Add("3", "unspoken Dreams");
            ICollection SortList_Keys = SortList.Keys;
            foreach (var val in SortList_Keys)
            {
                Console.WriteLine(val + "-" + SortList[val]);
            }

            // STACK CODE
            Console.WriteLine(" \n STACK");
            Stack MyStack = new Stack();
            MyStack.Push("Shantanu");
            MyStack.Push("Bonzi");
            MyStack.Push("unspoken Dreams");
            Console.WriteLine("Stack available : {0}", MyStack.Count);
            Console.WriteLine("Top Stack element : {0} ", MyStack.Pop());
            Console.WriteLine("Total number Stack remaining : {0}", MyStack.Count);

            // Queue CODE
            Console.WriteLine(" \n QUEUE");
            Queue queue = new Queue();
            queue.Enqueue(4);
            queue.Enqueue(3);
            queue.Enqueue(7);
            queue.Enqueue("Four");
            Console.WriteLine("Total Queue : {0}", queue.Count);
            Console.WriteLine("Top queue Element:{0}", queue.Dequeue());
            Console.WriteLine("Number Queue remaing after poping: {0}", queue.Count);

            Console.WriteLine("\n \n Generic COLLECTION Data..");
            Console.WriteLine(" \n LIST");
            // List Code
            List<int> MyList = new List<int>();
            MyList.Add(2);
            MyList.Add(20);
            MyList.Add(200);
            foreach (int data in MyList)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine(" \n DICTIONARY");
            // DICTIONARY code here
            Dictionary<int, string> dct = new Dictionary<int, string>();
            dct.Add(1, "Shantanu");
            dct.Add(2, "Bonzi");
            dct.Add(3, "unspoken Dreams");
            dct.Add(4, "Hello");
            foreach (KeyValuePair<int, string> kvp in dct)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }

            Console.WriteLine(" \n GENERIC SORTEDLIST ");
            // SORTEDLIST code
            SortedList<string, string> sl = new SortedList<string, string>();
            sl.Add("Hello", "World");
            sl.Add("See you", "Next Week");
            sl.Add("Shantanu", "Bonzi");
            sl.Add("Unspoken", "Dreams");
            foreach (KeyValuePair<string, string> kvp in sl)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }

            Console.WriteLine(" \n GENERIC STACK ");
            // STACK code
            Stack<string> stk = new Stack<string>();
            stk.Push("CAT");
            stk.Push("DOG");
            stk.Push("Hourse");
            stk.Push("Bat");
            foreach (string DATA in stk)
            {
                Console.WriteLine(DATA);
            }

            Console.WriteLine(" \n GENERIC QUEUE ");
            // QUEUE code
            Queue<string> QUE = new Queue<string>();
            QUE.Enqueue("Yamaha");
            QUE.Enqueue("Hero");
            QUE.Enqueue("Bajaj");
            QUE.Enqueue("Royal Enfield");            foreach (string DATA in QUE)
            {
                Console.WriteLine(DATA);
            }

            Console.ReadLine();
        }
    }
}
