using System.Collections;

public class DataStructures
{
    
    public static void Main(string[]args)
    {
        Console.WriteLine("hello world");
        StackExample();
        QueueExample();
        SetExample();
        LinkedListExample();
        ListExample();
        DictionaryExample();
    }




    /// <summary>
    /// Example of LIFO
    /// </summary>
    private static void StackExample()
    {
        Stack<string> strings = new Stack<string>();
        strings.Push("Apple");
        strings.Push("Coconut");
        strings.Push("Orange");
        Console.WriteLine("At the top of the stack is this: " + strings.Peek()); //Orange shows

        strings.Pop(); //
        Console.WriteLine(strings.Peek()); //Coconut now shows 
    }
    /// <summary>
    /// Example of FIFO 
    /// </summary>
    private static void QueueExample()
    {
        Queue<string> strings = new Queue<string>();
        strings.Enqueue("Apple");
        strings.Enqueue("Coconut");
        strings.Enqueue("Orange");
        Console.WriteLine(strings.Peek()); //Apple shows

        strings.Dequeue();

        Console.WriteLine(strings.Peek()); //Coconut shows because apple is now out of the queue.

        Console.WriteLine($"{string.Join(", ",strings)}"); //String interpolation
    }

    /// <summary>
    /// Example of sets...sets don't exist like in Java. HashSet is the way to go here
    /// </summary>
    private static void SetExample()
    {
        HashSet<string> mySet = new HashSet<string>();

        mySet.Add("Nintendo");
        mySet.Add("Playstation");
        mySet.Add("Xbox");
        mySet.Add("Mobile");
        mySet.Add("PC");

        if (mySet.Contains("Nintendo"))
            Console.WriteLine("Nintendo has been found in the set.");
        else
            Console.WriteLine("Something has gone wrong.");

        foreach(string s in mySet)
        {
            if(s.Equals("Xbox"))
            {
                Console.WriteLine("Xbox has been found!");
            }
        }
    }

    /// <summary>
    /// Linked List has a reference to the element and another reference to the next. I believe the data is stored in the heap.
    /// </summary>
    private static void LinkedListExample()
    {
        string[] listOfFruits = { "Apple", "Orange", "Pineapple", "Mango", "Peach" };
        LinkedList<string> strings = new LinkedList<string>(listOfFruits);

        strings.AddFirst("Blackberry");
        //string newString = strings.Find(x => x.Equals("Apple")); This doesn't work as the signature isn't expecting a predicate.
        foreach (string s in listOfFruits)
        {
            if (s.Contains("Peach"))
            {
                Console.WriteLine("Peach found");
            }
        }

    }

    private static void ListExample()
    {
        string[] listOfFruits = { "Apple", "Orange", "Pineapple", "Mango", "Peach" };
        List<string> strings = new List<string>(listOfFruits);

        string newString = strings.Find(x => x == "Peach"); //predicate example. 
        Console.WriteLine("New String: " + newString);
    }

    /// <summary>
    /// Dictionaries are more focused on pairs of data.
    /// </summary>
    private static void DictionaryExample()
    {
        Dictionary<int, string> newYorkBouroughs = new Dictionary<int, string>();

        newYorkBouroughs.Add(1, "Queens");
        newYorkBouroughs.Add(2, "The Bronx");
        newYorkBouroughs.Add(3, "Manhattan");
        newYorkBouroughs.Add(4, "Brooklyn");
        newYorkBouroughs.Add(5, "Staten Island");


        Console.WriteLine(newYorkBouroughs.ContainsKey(1));
        Console.WriteLine(newYorkBouroughs.ContainsValue("Brooklyn"));

        Console.WriteLine(newYorkBouroughs.Remove(1));
        Console.WriteLine(newYorkBouroughs.ContainsKey(1));


        foreach(KeyValuePair<int,string> kvp in newYorkBouroughs)
        {
            Console.WriteLine(kvp);
        }
    }
}