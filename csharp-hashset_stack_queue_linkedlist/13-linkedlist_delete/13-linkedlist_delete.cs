using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> currentNode = myLList.First;
        int i = -1;
        while (currentNode != null)
        {
            i++;
            if (i == index)
                myLList.Remove(currentNode);
            currentNode = currentNode.Next;
        }
    }
}
