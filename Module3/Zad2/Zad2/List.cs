using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Listy
{
    public class List
    {
        public string this[int index]
        {
            get { return FindNode(index).Data; }
            set { FindNode(index).Data = value; }
        }

        class Node
        {
            public string Data;
            public Node Next;

        }

        private Node head=null;

        public bool IsEmpty()
        {
            return head == null;
        }

        public void AddToHead(string s)
        {
            Node tmp = new Node();
            tmp.Data = s;
            tmp.Next = head;
            head = tmp;
        }

        public string DeleteFromHead()
        {
            if (head == null)           //lista pusta
                throw new InvalidOperationException("Lista jest pusta");
            string x = head.Data;
            head = head.Next;
            return x; 
        }       
       

        public int GetCount()
        {
            int i;
            Node tmp;
            for (i = 0, tmp = head; tmp != null; i++, tmp = tmp.Next) ;
            return i;
        }

        private Node FindNode(int index)
        {
            int i = 0;
            Node tmp = head;

            while( tmp != null && i < index)
            {
                tmp = tmp.Next;
                i++;
            }

            if (tmp == null)
            {
                throw new IndexOutOfRangeException("Nie ma elementu o podanym ineksie");
            }
            return tmp;
        }

    }
}
