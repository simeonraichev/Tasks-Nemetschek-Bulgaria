using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_implementation
{
    class LinkedListStack<T> : IStack<T>
    {
        private LinkedList<T> list;
        public LinkedListStack()
        {
            list = new LinkedList<T>();
        }
        public void Push(T item)
        {
            list.AddFirst(item);
        }
        public T Pop()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }
            T item = list.First.Value;
            list.RemoveFirst();
            return item;
        }
        public T Peek()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }
            return list.First.Value;
        }
        public int Count { get { return list.Count; } }
        public bool IsEmpty { get { return list.Count == 0; } }
    }
}
