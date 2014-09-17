using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumerExercise
{
    public class Producer
    {
        public void Run(BoundedBuffer buf, int numberOfInts)
        {
            for (int i = 0; i < numberOfInts; i++)
            {
                buf.Put(i);
                Console.WriteLine("Produceret: " + i);
            }
        }
    }
}
