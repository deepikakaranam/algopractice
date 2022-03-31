using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList1
{
    class ReverseLinkedList
    {

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

        public ListNode reverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode p = reverseList(head.next);
            head.next.next = head;
            head.next = null;
            return p;
        }

    }

}
