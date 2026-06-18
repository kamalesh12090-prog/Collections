using System;
using System.Collections;
using System.Linq;

namespace CollectionsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("   PART 1: ARRAYLIST");
            Console.WriteLine("=========================================");
            ArrayListDemo();

            Console.WriteLine("\n=========================================");
            Console.WriteLine("   PART 2: SORTEDLIST");
            Console.WriteLine("=========================================");
            SortedListDemo();

            Console.WriteLine("\n=========================================");
            Console.WriteLine("   PART 3: WHY GENERICS ARE PREFERRED NOW");
            Console.WriteLine("=========================================");
            GenericComparisonNote();
        }

        static void ArrayListDemo()
        {
            ArrayList list = new ArrayList();

            list.Add(10);
            list.Add("Hello");
            list.Add(3.14);
            list.Add(true);

            Console.WriteLine($"Count after adds      : {list.Count}");

            list.Insert(1, "Inserted");
            Console.WriteLine($"After Insert(1, ...)  : {string.Join(", ", list.ToArray())}");

            list.Remove("Hello");
            list.RemoveAt(0);
            Console.WriteLine($"After Remove + RemoveAt: {string.Join(", ", list.ToArray())}");

            Console.WriteLine($"Contains(3.14)        : {list.Contains(3.14)}");
            Console.WriteLine($"IndexOf(true)         : {list.IndexOf(true)}");

            ArrayList numbers = new ArrayList { 5, 2, 9, 1, 7 };
            numbers.Sort();
            Console.WriteLine($"Sorted numbers        : {string.Join(", ", numbers.ToArray())}");

            numbers.Reverse();
            Console.WriteLine($"Reversed numbers      : {string.Join(", ", numbers.ToArray())}");

            int firstNumber = (int)numbers[0];
            Console.WriteLine($"First number (cast)   : {firstNumber}");

            Console.Write("Iterating list        : ");
            foreach (object item in list)
            {
                Console.Write($"[{item}] ");
            }
            Console.WriteLine();

            list.Clear();
            Console.WriteLine($"Count after Clear()   : {list.Count}");
        }

        static void SortedListDemo()
        {
            SortedList students = new SortedList();

            students.Add(103, "Charlie");
            students.Add(101, "Alice");
            students.Add(105, "Eve");
            students.Add(102, "Bob");

            Console.WriteLine("Students sorted by ID:");
            foreach (DictionaryEntry entry in students)
            {
                Console.WriteLine($"  ID {entry.Key} -> {entry.Value}");
            }

            Console.WriteLine($"\nContainsKey(102)      : {students.ContainsKey(102)}");
            Console.WriteLine($"ContainsValue(\"Eve\")  : {students.ContainsValue("Eve")}");
            Console.WriteLine($"Value at key 101      : {students[101]}");

            Console.WriteLine($"GetKey(0)             : {students.GetKey(0)}");
            Console.WriteLine($"GetByIndex(0)         : {students.GetByIndex(0)}");

            Console.WriteLine($"All Keys              : {string.Join(", ", students.Keys.Cast<object>())}");
            Console.WriteLine($"All Values            : {string.Join(", ", students.Values.Cast<object>())}");

            students.Remove(103);
            students.RemoveAt(0);

            Console.WriteLine($"\nAfter removals, Count : {students.Count}");
            foreach (DictionaryEntry entry in students)
            {
                Console.WriteLine($"  ID {entry.Key} -> {entry.Value}");
            }
        }

        static void GenericComparisonNote()
        {
            System.Collections.Generic.SortedList<int, string> genericStudents =
                new System.Collections.Generic.SortedList<int, string>
                {
                    { 103, "Charlie" },
                    { 101, "Alice" },
                    { 102, "Bob" }
                };

            Console.WriteLine("Generic SortedList<int,string> (no casting needed):");
            foreach (var pair in genericStudents)
            {
                Console.WriteLine($"  ID {pair.Key} -> {pair.Value}");
            }
        }
    }
}