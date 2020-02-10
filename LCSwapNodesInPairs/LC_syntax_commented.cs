public class Solution
{
	public ListNode SwapPairs(ListNode head)
	{
		"

		//many of these node problems are easier if you create a node at the start.
		//these two lines are creating a new node and then appending the head to it.
		ListNode swappedList = new ListNode(0);
		swappedList.next = head;

		//we need to store the nodes somewhere while shuffling them around without deleting any.
		//previous node is set to the new node we created, and current node starts right after it
		ListNode previousNode = swappedList;
		ListNode currentNode = head;

		//we want to keep swapping as long as we are on a node and there is one after it
		while (currentNode != null && currentNode.next != null)
		{
			//in the example (1, 2, 3, 4) this would be node (3)
			ListNode tempNode = currentNode.next.next;

			//we will set the new start of the list to (2).
			//previous.next is currently (1) because we added that node at the start.
			//current.next is (2). so this will rearrange it to (0) -> (2)
			previousNode.next = currentNode.next;

			//remember previous node is (0), before the start of the list. 
			//we just set .next to (2), so now we have to get the (1) node back in, which is where
			//our currentNode variable was set to.
			previousNode.next.next = currentNode;

			//now we have (0) -> 2 -> (1), so we need to get to the start of the next node pair.
			//we stored that one at the start of the method in tempNode. this will add (3) to the end.
			currentNode.next = tempNode;

			//now that our list is (0) -> (2) -> (1) -> (3) we want to set up our pointer on the next set.
			//set our previousNode pointer to (1), and our currentNode pointer to (3) and repeat.
			previousNode = currentNode;
			currentNode = tempNode;
		}

		//return the .next value because we added the (0) node at the start and dont want it returned.
		return swappedList.next;
	}
}