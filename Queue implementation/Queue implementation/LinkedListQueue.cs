using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_implementation
{
    public class LinkedListQueue<T> : IQueue<T>
    {
        private LinkedList<T> _list;

        public LinkedListQueue()
        {
            _list = new LinkedList<T>();
        }

        public void Enqueue(T item)
        {
            _list.AddLast(item);
        }

        public T Dequeue()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            var item = _list.First.Value;
            _list.RemoveFirst();
            return item;
        }

        public T Peek()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            return _list.First.Value;
        }

        public int Count
        {
            get
            {
                return _list.Count;
            }
        }
    }
}
