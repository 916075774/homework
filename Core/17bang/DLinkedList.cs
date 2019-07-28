using System;
using System.Collections.Generic;
using System.Text;

namespace Core._17bang
{
    public class DLinkedList
    {
        public DLinkedList(DLinkedListNode node)
        {
            Head = node;
            Tail = node;
        }

        public DLinkedListNode Head { get; set; }
        public DLinkedListNode Tail { get; set; }

        public void AddAfter(DLinkedListNode node, DLinkedListNode target)
        {
            if (Tail==target)
            {
                target.Next = node;
                node.Previous = target;

                Tail = node;
            }
            else
            {
                DLinkedListNode oldNext = target.Next;

                node.Previous = target;
                node.Next = oldNext;

                oldNext.Previous = node;
                target.Next = node;
            }
        }
    }

    public class DLinkedListNode
    {
        public DLinkedListNode Previous { get; set; }
        public DLinkedListNode Next { get; set; }
    }

}
