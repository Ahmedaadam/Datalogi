using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalogi_02
{
    public class MyStack<T> : SimpleStack<T>, SimpleQueue<T>
    {
        private MyNode<T> Top = null; //motsvarar top of stack
        private MyNode<T> Last = null; //motsvarar bottom of stack
       public void Push(T value)
        {
            var oldTop = Top;
            Top = new MyNode<T>();
            Top.Data = value;
            if(Top != null)
            {
                
                Top.Next = oldTop;
            }
            else
            {
                Last = Top;
            }
            
        }
        public T Peek()
        {
            if(Top == null)
            {
                throw new Exception("Stacken är tom. Ingen värde att se");
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
                throw new Exception("Tom stack, finns inget värde att poppa. ");
            }
            else
            {
               T value = Top.Data;
                Top = Top.Next;
                return value;
            }
        }

        public void AddLast(T value)
        {
            if(Last == null)
            {
                Push(value);
            }
            else
            {
                //Jag skapar en variabel för den sista i kön
                var oldLast = Last;
                //Jag skapar en ny node sist i kön
                Last = new MyNode<T>();
                //Lägger till data i node
                Last.Data = value;
                // Om det finns data i kön så refererar jag till den nästsista i kön
                oldLast.Next = Last;
            }
        }

        public T GetFirst()
        {

            return Peek(); 
        }

        public void RemoveFirst()
        {
            Pop();
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

    public interface SimpleQueue<T>
    {
        public void AddLast(T value);
        public T GetFirst();
        public void RemoveFirst();

    }
}
