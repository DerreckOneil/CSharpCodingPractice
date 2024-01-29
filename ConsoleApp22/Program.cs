using System;
using System.Collections;
public class MyQueue
{
    Stack stack1 = new Stack();
    Stack stack2 = new Stack();
    public MyQueue()
    {

    }

    public void Push(int x)
    {
        if (Empty())
        {
            stack1.Push(x);//1
            stack2.Push(x);
        }
        else
        {
            stack1.Push(x);
            stack2.Clear();

            foreach (int y in stack1)
            {
                Console.WriteLine("Pushing on y: " + y);
                stack2.Push(y);
            }
        }
    }
    public int Pop()
    {
        if(stack1.Count == 0)
            throw new Exception("Trying to pop with nothing in the stack...");

        Stack temp = new();
        object[] a = stack1.ToArray();

        Console.WriteLine("The ending of this array is: "+ a[a.Length-1]);
        for(int i = a.Length-2; i >= 0; i--)
        {
            Console.WriteLine("Putting in: " + a[i]);
            temp.Push(a[i]);
        }
        stack1 = temp;
        
        return (int) stack2?.Pop();
    }
    public int Peek()
    {
        return (int) stack2?.Peek();
    }
    public bool Empty()
    {
        bool result = (stack1.Count == 0);
        return result;
    }
}

public class Program
{
    private static void Main()
    {
        MyQueue myQueue = new MyQueue();
        myQueue.Push(1); // queue is: [1]
        myQueue.Push(2); // queue is: [1, 2] (leftmost is front of the queue)
        Console.WriteLine("Pop! num: " + myQueue.Pop());
        myQueue.Push(5); // queue is: [2,3,4,5]
        Console.WriteLine("Pop! num: "+myQueue.Pop()); //[3,4,5]
        Console.WriteLine("Pop! num: "+myQueue.Pop()); //[4,5]
        Console.WriteLine("Pop! num: "+myQueue.Pop()); //[5]
        Console.WriteLine("Pop! num: "+myQueue.Pop()); //[]

        //Console.WriteLine(myQueue.Peek()); // return 1
        //Console.WriteLine(myQueue.Pop()); // return 1, queue is [2]
        //Console.WriteLine(myQueue.Empty()); // return false
    }

}