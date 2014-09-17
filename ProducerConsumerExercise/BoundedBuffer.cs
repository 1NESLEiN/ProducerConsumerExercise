using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumerExercise
{
    public class BoundedBuffer
    {
        private Object _lockObject = new object();
        private Queue<int> _bufferData;
        private int _capacity;

        public BoundedBuffer(int capacity)
        {
            this._capacity = capacity;
            _bufferData = new Queue<int>(_capacity);
        }

        public void Put(int element)
        {
            if (_bufferData.Count != _capacity)
            {
                _bufferData.Enqueue(element);
            }
        }

        public int Take()
        {
            return _bufferData.Dequeue();
        }

        public bool IsFull()
        {
            if (_bufferData.Count != _capacity)
            {
                return false;
            }
            return true;
        }
    }
}
