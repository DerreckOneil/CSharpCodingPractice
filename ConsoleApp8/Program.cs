
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
public class Program
{

    static void Main()
    {
        //ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        //ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        //ListNode l1 = new ListNode(9);
        //ListNode l2 = new ListNode(9);
        ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
        ListNode l2 = new ListNode(9, new ListNode(9, new ListNode(9)));

        //9 9 9 9 
        //9 9 9 
        //8 9 9 0 1
        //so the sum is 10998

        //9 9 9 
        //9 9 9 9 
        //8 9 9 0 1
        //so the sum is 10998


        ListNode result = AddTwoNumbers(l2, l1);
        Console.Write("The sum is: ");


        ListNode current = result;
        while (current != null)
        {
            Console.Write(current.val + ",");
            current = current.next;
        }


    }
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        if ((l1 == null && l2 == null))
            return null;
        else if (l1 != null && l2 == null)
        {
            Console.WriteLine("This is lopsided (l2)");
            l2 = new ListNode(0); //Put a place holder
        }
        else if (l2 != null && l1 == null)
        {
            Console.WriteLine("This is lopsided (l1)");
            l1 = new ListNode(0); //put a place holder
        }

        Console.WriteLine("Two values are: \n" + l1.val + " And: " + l2.val);

        int sum = l1.val + l2.val;

        if (sum > 9)
        {
            //carry the one
            sum -= 10;
            if (l1.next == null && l2.next != null)
                l2.next.val++;
            else if (l2.next == null && l1.next != null)
                l1.next.val++;
            else if (l1.next != null && l2.next != null)
                l1.next.val++;
            else if (l1.next == null && l2.next == null)
            {
                return new ListNode(sum, new ListNode(1));
            }
            Console.WriteLine("sum value: " + sum);
        }
        
        return new ListNode(sum, AddTwoNumbers(l1.next, l2.next));
    }

}