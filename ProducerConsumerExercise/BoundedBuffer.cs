using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumerExercise
{
    public class BoundedBuffer
    {
        private int _capacity;
        private Object _lockObject = new object();
        private Queue<int> _bufferData = new Queue<int>();

        public BoundedBuffer(int capacity)
        {
            this._capacity = capacity;
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
