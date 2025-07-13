using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLAlg
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
    internal class CSLibAlgLL
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2) //21. Merge Two Sorted Lists
        {
            ListNode _MergeTwoLists = new ListNode();
            return _MergeTwoLists;
        }

        public ListNode DeleteDuplicates(ListNode head) //83. Remove Duplicates from Sorted List
        {
            ListNode _DeleteDuplicates = new ListNode();
            return _DeleteDuplicates;
        }
    }
}
