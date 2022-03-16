namespace Learning.LeetCode
{
    public static class DeleteDuplicates
    {
        public static ListNode DeleteDuplicatesInList(ListNode head)
        {
            ListNode firstPointer = head.next, secondPointer = head, prevNode = null;

            int similarFreq = 0;
            while (firstPointer != null)
            {

                if (firstPointer.val != secondPointer.val)
                {
                    if (similarFreq > 0 && prevNode == null)
                    {
                        head = secondPointer;
                    }

                    if (similarFreq > 0 && prevNode != null)
                    {
                        prevNode.next = secondPointer;
                    }

                    secondPointer = firstPointer;
                    prevNode = secondPointer;
                    similarFreq = 0;
                }
                else
                {
                    similarFreq++;
                }

                firstPointer = firstPointer.next;
            }

            return head;
        }

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

    }
}
