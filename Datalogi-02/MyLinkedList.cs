using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalogi_02
{
    public class MyLinkedList<T>
    {
        private MyNode<T> Head = null;
        public MyNode<T> Current = null;

        public void Next()
        {
            Current = Current.Next;
        }
        public void Reset()
        {
            Current = Head;
        }

        public void Push(T value)
        {
            MyNode<T> oldHead = Head;
            Head = new MyNode<T>();
            Head.Data = value;
            Head.Next = oldHead;
            if (Current == null)
            {
                Current = Head;
            }
        }

        public T Get(int index)
        {
            var nodeReference = Head;
            for (int i = 0; i < index; i++)
            {
                nodeReference = nodeReference.Next;
            }
            return nodeReference.Data;
        }

        public void RemoveAt(int index)
        {
            var nodeToDelete = Head;
            // Steg 1 Hitta indexet som sak tas bort
            for(int i = 0; i < index - 1; i++)
            {
                 nodeToDelete = nodeToDelete.Next;

            }

            // Steg 2 Ta bort noden på indexet
            nodeToDelete.Next = nodeToDelete.Next.Next;
        }
    }
    public class MyNode<T>
    {
        public T Data { get; set; }
        public int Index { get; set; }
        public MyNode<T> Next { get; set; }
    }
}

