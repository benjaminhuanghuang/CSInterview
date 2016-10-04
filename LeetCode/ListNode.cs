public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }

      public static ListNode BuildList(int[] nums)
      {
            ListNode head = new ListNode(nums[0]);
            ListNode curr = head;
            for (int i = 1; i< nums.Length; i++)
            {
                  curr.next = new ListNode(nums[i]);  
                  curr = curr.next;    
            }
            return head;
      }
}