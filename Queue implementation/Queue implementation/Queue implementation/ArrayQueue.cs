using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_implementation
{
    public class ArrayQueue<T> : IQueue<T>
    {
        private T[] _items;
        private int _head;
        private int _tail;

        public ArrayQueue()
        {
            _items = new T[10];
            _head = 0;
            _tail = 0;
        }

        public void Enqueue(T item)
        {
            if (_tail == _items.Length)
            {
                var newArray = new T[_items.Length * 2];
                Array.Copy(_items, _head, newArray, 0, _items.Length - _head);
                Array.Copy(_items, 0, newArray, _items.Length - _head, _tail - _head);
                _items = newArray;
                _head = 0;
                _tail = Count;
            }
            _items[_tail++] = item;
        }

        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            var item = _items[_head];
            _items[_head++] = default(T);
            if (_head == _items.Length)
            {
                _head = 0;
            }
            return item;
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            return _items[_head];
        }

        public int Count
        {
            get
            {
                return (_tail - _head + _items.Length) % _items.Length;
            }
        }
            //Steps for enqueue:
            //1.Check the queue is full or not
            //2.If full, print overflow and exit
            //3.If queue is not full, increment tail and add the element
            
            //Steps for dequeue:
            //1.Check queue is empty or not
            //2.if empty, print underflow and exit
            //3.if not empty, print element at the head and increment head
    }
}
