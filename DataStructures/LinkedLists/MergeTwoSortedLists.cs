namespace DataStructures.LinkedLists;
public class MergeTwoSortedLists
{
    public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        var dummyHead = new ListNode(0);
        var current = dummyHead;
        while (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                current.next = l1;
                l1 = l1.next;
            }
            else
            {
                current.next = l2;
                l2 = l2.next;
            }
            current = current.next;
        }
        if (l1 != null)
        {
            current.next = l1;
        }
        else
        {
            current.next = l2;
        }
        return dummyHead.next;
    }
}
