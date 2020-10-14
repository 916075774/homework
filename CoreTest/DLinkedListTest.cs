using Core._17bang;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Yz.Csharp.Core
{
    public class DLinkedListTest
    {
        [Test]
        public void ConstuctorTest()
        {
            DLinkedListNode node = new DLinkedListNode();
            DLinkedList list = new DLinkedList(node);
            Assert.That(list.Head, Is.EqualTo(node));
            Assert.That(list.Tail, Is.EqualTo(node));
        }

        [Test]
        public void AddAfterTestOne()
        {

            //建立了一个节点,把节点添加到链表里面，链表名字是list
            DLinkedListNode node = new DLinkedListNode();
            DLinkedList list = new DLinkedList(node);

            //new了一个新节点，添加到链表里面
            DLinkedListNode newNode = new DLinkedListNode();
            list.AddAfter(newNode, node);

            //链表的头部是node
            Assert.That(list.Head, Is.EqualTo(node));
            //node节点的上一个是newNode
            Assert.That(node.Next, Is.EqualTo(newNode));
            //newNode节点的下一个是node
            Assert.That(newNode.Previous, Is.EqualTo(node));
            //尾巴是newNode
            Assert.That(list.Tail, Is.EqualTo(newNode));

        }

        [Test]
        public void AddAfterTestTwo()
        {

            //建立了一个节点,把节点添加到链表里面，链表名字是list
            DLinkedListNode node = new DLinkedListNode();
            DLinkedList list = new DLinkedList(node);

            //new了一个新节点，添加到链表node节点后面
            DLinkedListNode node_1 = new DLinkedListNode();
            list.AddAfter(node_1, node);

            //new了一个新节点，添加到链表node节点后面
            DLinkedListNode newNode = new DLinkedListNode();
            list.AddAfter(newNode, node);

            //链表的头部是node
            Assert.That(list.Head, Is.EqualTo(node));
            //node节点的下一个是newNode
            Assert.That(node.Next, Is.EqualTo(newNode));

            //newNode节点的下一个是node1
            Assert.That(newNode.Previous, Is.EqualTo(node));
            Assert.That(newNode.Next, Is.EqualTo(node_1));
            Assert.That(node_1.Previous, Is.EqualTo(newNode));

            //尾巴是node1
            Assert.That(list.Tail, Is.EqualTo(node_1));

        }
    }
}
