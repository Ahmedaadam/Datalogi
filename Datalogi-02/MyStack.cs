using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalogi_02
{
    public class MyStack<T> : SimpleStack<T>
    {
        private MyNode<T> Top = null;
       public void Push(T value)
        {
            MyNode<T> oldNode = Top;
            Top = new MyNode<T>();
            Top.Data = value;
            Top.Next = oldNode;
        }
        public T Peek()
        {
            if(Top == null)
            {
                throw new Exception("Listan är tom");
            }
            else
            {
                return Top.Data;
            }
            
        }

        public T Pop()
        {
            if(Top == null)
            {
                throw new Exception(" WTF ");
            }
            else
            {
               T value = Top.Data;
                Top = Top.Next;
                return value;
            }
        }

        

        public class MyNode<T>
        {
            public T Data { get; set; }
            public MyNode<T> Next { get; set; }
        }
    }

    public interface SimpleStack<T> 
    {
        public void Push(T value);
        public T Pop();
        public T Peek();
    }
}
