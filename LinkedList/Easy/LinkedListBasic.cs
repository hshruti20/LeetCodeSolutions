using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListBasic
{
    class Program
    {
        public class Node
        {
            internal int data;
            internal Node next;

            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }


        public class LinkedList
        {
            internal Node head;

            public LinkedList()
            {
                this.head = null;
            }


            public void addDataToHead(int data)
            {
                Node node = new Node(data);
                if (head == null)
                {
                    head = node;
                }
                else
                {
                    node.next = head;
                    head = node;
                }
            }

            public void printList()
            {
                //LinkedList list = new LinkedList();
                Node currentNode = head;
                while (currentNode != null)
                {
                    Console.WriteLine(currentNode.data);
                    currentNode = currentNode.next;
                }
            }

            public void deleteNodeFromHead()
            {
                if (head != null && head.next != null)
                {
                    Node temp = head;
                    head = head.next;
                    temp.next = null;
                }
                else
                {
                    head = null;
                }
            }

            public void addDataToTail(int data)
            {
                Node node = new Node(data);
                if (head == null)
                {
                    head = node;
                    return;
                }

                Node lastNode = getLastNode();
                lastNode.next = node;
            }

            public void deleteNodeAtTail()
            {

                if (head == null)
                    return;
                if (head.next == null)
                    return;

                Node secondLast_node = head;
                while (secondLast_node.next.next != null)
                {
                    secondLast_node = secondLast_node.next;
                }
                secondLast_node.next = null;
            }

            public Node getLastNode()
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                return temp;
            }

            public void addDataAfter(Node prev_node, int new_data)
            {
                if (prev_node == null)
                    return;

                Node new_node = new Node(new_data);
                new_node.next = prev_node.next;
                prev_node.next = new_node;
            }


            public void deleteAllDataAfter(Node prev_node, int data)
            {
                if (prev_node == null)
                    return;

                Node temp = new Node(data);
                prev_node.next = temp.next;
                temp = null;
            }

            public void deleteDataAt(Node prev_node, int data)
            {
                if (prev_node == null)
                    return;

                Node temp = head;
                if (temp != null && temp.data == data)
                {
                    head = temp.next;
                    return;
                }
                while (temp != null &&
                   temp.data != data)
                {
                    prev_node = temp;
                    temp = temp.next;
                }
                if (temp == null)
                    return;

                prev_node.next = temp.next;
            }

           /* public bool detectLoop(LinkedList list)
            {
                if (head == null)
                 return false;
                Boolean loop = false;
                Node slow = list.head;
                Node fast = slow.next;
                while(slow!=null && fast!=null && fast.next!=null)
                {
                    
                    if (slow == fast)
                        loop = true;
                    
                    slow = slow.next;
                    fast = fast.next.next;
                }
                return loop;
               
            } */
        }

        static void Main(string[] args)
        {
            LinkedList lst = new LinkedList();

            //add data to head
            lst.addDataToHead(10);
            lst.addDataToHead(20);
            lst.addDataToHead(30);
            lst.addDataToHead(40);
            lst.addDataToHead(50);
            lst.addDataToHead(60);

            //delete Node From head
            lst.deleteNodeFromHead();

            //add data to tail
            lst.addDataToTail(0);

            //delete data at tail
            lst.deleteNodeAtTail();

            //insert data after
            lst.addDataAfter(lst.head.next, 35);

            //delete data after
            //lst.deleteDataAt(lst.head.next, 40);

            //delete all data after
            // lst.deleteAllDataAfter(lst.head.next, 30);

            lst.printList();
            Console.ReadLine();
        }
    }

}
