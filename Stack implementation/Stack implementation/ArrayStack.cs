using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_implementation
{
    class ArrayStack<T> : IStack<T>
    {
        private T[] array;
        private int count;
        public ArrayStack()
        {
            array = new T[10];
            count = 0;
        }
        public void Push(T item)
        {
            if (count == array.Length)
            {
                throw new StackOverflowException();
            }
            array[count++] = item;
        }
        public T Pop()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }
            return array[--count];
        }
        public T Peek()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }
            return array[count - 1];
        }
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
    }
}
